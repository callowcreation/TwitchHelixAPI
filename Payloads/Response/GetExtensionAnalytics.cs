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

namespace TwitchHelixAPI.Payloads.Response.Analytics
{
    [Serializable]
    public class GetExtensionAnalytics : Payload<GetExtensionAnalytics.ExtensionAnalytics>
    {
        [Serializable]
        public class ExtensionAnalytics
        {
            public string extension_id { get; set; }
            public string URL { get; set; }
            public string type { get; set; }
            public DateRange date_range { get; set; }
        }

        public Pagination pagination { get; set; }
    }
}