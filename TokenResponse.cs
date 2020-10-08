#region Author
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

namespace TwitchHelixAPI
{
    /// <summary>
    /// Expected token response properties
    /// </summary>
    [Serializable]
    public class TokenResponse
    {
        /// <summary>
        /// Scoped access token
        /// </summary>
        public string access_token;

        /// <summary>
        /// Refresh token used refresh the access token when expired
        /// </summary>
        public string refresh_token;

        /// <summary>
        /// Amount of seconds the token will live
        /// </summary>
        public long expires_in;

        /// <summary>
        /// Scopes requires to sccess desired endpoints
        /// </summary>
        public string scope;

        /// <summary>
        /// User access token type 
        /// </summary>
        public string token_type;

        /// <summary>
        /// The Date/Time the toke will expire
        /// </summary>
        public string expires;
    }
}
