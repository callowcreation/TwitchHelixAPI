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
    public class CreateStreamMarker : Payload<CreateStreamMarker.Marker>
    {
        [Serializable]
        public class Marker
        {
            public string id { get; set; }
            public string created_at { get; set; }
            public string description { get; set; }
            public string position_seconds { get; set; }
        }
    }
}
