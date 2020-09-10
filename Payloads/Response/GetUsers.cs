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
    public class GetUsers : Payload<GetUsers.User>
    {
        [Serializable]
        public class User
        {
            public string id { get; set; }
            public string login { get; set; }
            public string display_name { get; set; }
            public string type { get; set; }
            public string broadcaster_type { get; set; }
            public string description { get; set; }
            public string profile_image_url { get; set; }
            public string offline_image_url { get; set; }
            public int view_count { get; set; }
            public string email { get; set; }
        }
    }
}