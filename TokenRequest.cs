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
    /// Propertirs required to make a valid token request
    /// <para>Create an application here: https://dev.twitch.tv/console </para>
    /// </summary>
    [Serializable]
    public class TokenRequest
    {
        /// <summary>
        /// The client id provided for the app
        /// </summary>
        public string clientId;

        /// <summary>
        /// The client secret provided for the app
        /// </summary>
        public string clientSecret;

        /// <summary>
        /// The redirect url that was used to create the app
        /// </summary>
        public string redirectUrl;

        /// <summary>
        /// The scopes required to used endpoints
        /// </summary>
        public string[] scopes;

        /// <summary>
        /// Force the user to go through the auth flow
        /// </summary>
        public bool forceVerify;
    }
}
