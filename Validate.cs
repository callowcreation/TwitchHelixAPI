#region Author
/*
     
     Jones St. Lewis Cropper (caLLow)
     
     Another caLLowCreation
     
     Visit us on Google+ and other social media outlets @caLLowCreation
     
     Thanks for using our product.
     
     Send questions/comments/concerns/requests to 
      e-mail: caLLowCreation@gmail.com
      subject: TwitchPubSubAPI
     
*/
#endregion

using System;

namespace TwitchHelixAPI
{
    /// <summary>
    /// Validation response object
    /// </summary>
    [Serializable]
    public struct Validate
    {
        /// <summary>
        /// Application client id
        /// </summary>
        public string client_id;

        /// <summary>
        /// Username or channel name
        /// </summary>
        public string login;

        /// <summary>
        /// Scopes matching the current access token
        /// </summary>
        public string[] scopes;

        /// <summary>
        /// The user id for the username/channel name
        /// </summary>
        public string user_id;
    }
}
