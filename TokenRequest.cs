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
    [Serializable]
    public class TokenRequest
    {
        public string clientId;
        public string clientSecret;
        public string redirectUrl;
        public string[] scopes;
        public bool forceVerify;
    }
}
