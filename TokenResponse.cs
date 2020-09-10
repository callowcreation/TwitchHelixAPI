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
    public class TokenResponse
    {
        public string access_token;
        public string refresh_token;
        public long expires_in;
        public string scope;
        public string token_type;
        public string expires;
    }
}
