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
    public class GetClips : Payload<GetClips.Clip>
    {
        [Serializable]
        public class Clip
        {
            public string id { get; set; }
            public string url { get; set; }
            public string embed_url { get; set; }
            public string broadcaster_id { get; set; }
            public string broadcaster_name { get; set; }
            public string creator_id { get; set; }
            public string creator_name { get; set; }
            public string video_id { get; set; }
            public string game_id { get; set; }
            public string language { get; set; }
            public string title { get; set; }
            public int view_count { get; set; }
            public DateTime created_at { get; set; }
            public string thumbnail_url { get; set; }
        }

        public Pagination pagination { get; set; }
    }
}