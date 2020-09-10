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

namespace TwitchHelixAPI.Payloads.Response
{
    [Serializable]
    public class StartCommercial : Payload<StartCommercial.Commercial>
    {
        [Serializable]
        public class Commercial
        {
            public int length { get; set; }
            public string message { get; set; }
            public int retry_after { get; set; }
        }
    }
}