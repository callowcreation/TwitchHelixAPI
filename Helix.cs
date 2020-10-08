﻿#region Author
/*
     
     Jones St. Lewis Cropper (caLLow)
     
     Another caLLowCreation
     
     Visit us on Google+ and other social media outlets @caLLowCreation
     
     Thanks for using our product.
     
     Send questions/comments/concerns/requests to 
      e-mail: caLLowCreation@gmail.com
      subject: TwitchHelixAPI
     
*/
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TwitchHelixAPI
{
    /// <summary>
    /// Provides a connection to the Twitch API information
    /// </summary>
    public class Helix
    {
        const string CODE_RESPONSE_TYPE = "code";

        static RNGCryptoServiceProvider s_RngCsp = new RNGCryptoServiceProvider();

        /// <summary>
        /// Get an endpoint based on the url and scopes requested within the access token
        /// </summary>
        /// <typeparam name="T">Type of data structure to parse JSON</typeparam>
        /// <param name="url">A fully qualified url endpoint</param>
        /// <param name="method">GET, PUT, POST</param>
        /// <param name="clientId">The client id provided for the app</param>
        /// <param name="accessToken">Access token with scopes to match the endpoint</param>
        /// <param name="makeRequest">The method used to get the data</param>
        /// <returns>Type of data structure to parse JSON</returns>
        public static Task<T> GetEndpoint<T>(string url, string method, string clientId, string accessToken, Func<string, string, string, string, Task<T>> makeRequest)
        {
            return makeRequest(url, method, clientId, accessToken);
        }

        /// <summary>
        /// Has the token expierd
        /// </summary>
        /// <param name="expires">Date string</param>
        /// <returns></returns>
        public static bool IsExpired(string expires)
        {
            DateTime date = DateTime.Parse(expires);
            int compare = DateTime.Compare(date, DateTime.Now);
            return compare == -1;
        }


        /// <summary>
        /// Make a request to get an access token
        /// </summary>
        /// <param name="path">Path to save encrypted token</param>
        /// <param name="tokenRequest">Propertirs required to make a valid token request</param>
        /// <param name="makeRequest">The method used to get the data</param>
        /// <param name="openBrowser">The method to open the web browser</param>
        /// <returns> Expected token response properties containing the tokens and expire time</returns>

        public async static Task<TokenResponse> MakeTokenRequest(string path, TokenRequest tokenRequest, Func<Dictionary<string, string>, Task<TokenResponse>> makeRequest, Action<string> openBrowser)
        {
            if (tokenRequest.forceVerify == false)
            {
                TokenResponse tokenResponse = DataIO.Load<TokenResponse>(path);
                if (tokenResponse != null && tokenResponse.refresh_token != null)
                {
                    DateTime date = DateTime.Parse(tokenResponse.expires);
                    int compare = DateTime.Compare(date, DateTime.Now);
                    if (compare == -1)
                    {
                        return await RefreshAccessToken(tokenRequest.clientId, tokenRequest.clientSecret, tokenResponse.refresh_token, makeRequest);
                    }
                    return tokenResponse;
                }
            }

            byte[] random = new byte[32];
            Helix.s_RngCsp.GetBytes(random);

            string codeVerifier = Convert.ToBase64String(random);
            string codeChallenge;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] challengeBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
                codeChallenge = Base64UrlEncode(challengeBytes);
            }

            string scope = string.Join(" ", tokenRequest.scopes);
            string state = codeChallenge;

            HttpListener http = new HttpListener();
            string prefix = tokenRequest.redirectUrl;
            if (prefix.LastOrDefault() != '/')
            {
                prefix += '/';
            }

            try
            {
                string authCode = string.Empty;
                string authState = string.Empty;

                http.Prefixes.Add(prefix);
                http.Start();

                string url = $"https://id.twitch.tv/oauth2/authorize?" +
                    $"client_id={tokenRequest.clientId}" +
                    $"&redirect_uri={tokenRequest.redirectUrl}" +
                    $"&response_type={Helix.CODE_RESPONSE_TYPE}" +
                    $"&scope={scope}" +
                    $"&state={state}" +
                    $"&force_verify={tokenRequest.forceVerify.ToString().ToLower()}";

                openBrowser.Invoke(url);

                HttpListenerContext context = await http.GetContextAsync();
                authCode = context.Request.QueryString["code"];
                authState = context.Request.QueryString["state"];

                string responseStr = "<HTML><BODY>You can close this window.</BODY></HTML>";
                byte[] responseBuffer = Encoding.UTF8.GetBytes(responseStr);
                context.Response.ContentLength64 = responseBuffer.Length;
                Stream outputStream = context.Response.OutputStream;
                outputStream.Write(responseBuffer, 0, responseBuffer.Length);
                outputStream.Close();

                if (authState != codeChallenge) throw new UnauthorizedAccessException("Unauthorized State");

                return await makeRequest.Invoke(new Dictionary<string, string>
                {
                    { "client_id", tokenRequest.clientId },
                    { "client_secret", tokenRequest.clientSecret },
                    { "code", authCode },
                    { "grant_type", "authorization_code" },
                    { "redirect_uri", tokenRequest.redirectUrl }
                });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                http.Stop();
            }
        }

        /// <summary>
        /// Call to refresh access token
        /// </summary>
        /// <param name="clientId">The client id provided for the app</param>
        /// <param name="clientSecret">The client secret provided for the app</param>
        /// <param name="refreshToken">The refresh token recieved from making an access token request</param>
        /// <param name="makeRequest">The method used to get the data</param>
        /// <returns> Expected token response properties containing the tokens and expire time</returns>
        public static async Task<TokenResponse> RefreshAccessToken(string clientId, string clientSecret, string refreshToken, Func<Dictionary<string, string>, Task<TokenResponse>> makeRequest)
        {
            return await makeRequest.Invoke(new Dictionary<string, string>
            {
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "refresh_token", refreshToken },
                { "grant_type", "refresh_token" }
            });
        }

        /// <summary>
        /// From https://github.com/IdentityModel/IdentityModel2 (src/IdentityModel/Base64Url.cs)
        /// </summary>
        /// <param name="buffer">The hash value for the specified byte array</param>
        /// <returns></returns>
        protected static string Base64UrlEncode(byte[] buffer)
        {
            var s = Convert.ToBase64String(buffer); // Standard base64 encoder
            s = s.Split('=')[0]; // Remove any trailing '='s
            s = s.Replace('+', '-'); // 62nd char of encoding
            s = s.Replace('/', '_'); // 63rd char of encoding
            return s;
        }
    }
}