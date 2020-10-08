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
    /// <summary>
    /// Clip information by clip ID (one or more), broadcaster ID (one only), or game ID (one only).
    /// </summary>
    [Serializable]
    public class GetClips : Payload<GetClips.Clip>
    {
        /// <summary>
        /// Clip information by clip ID (one or more), broadcaster ID (one only), or game ID (one only).
        /// </summary>
        [Serializable]
        public class Clip
        {
            /// <summary>
            /// ID of the clip being queried.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// URL where the clip can be viewed.
            /// </summary>
            public string url { get; set; }

            /// <summary>
            /// URL to embed the clip.
            /// </summary>
            public string embed_url { get; set; }

            /// <summary>
            /// User ID of the stream from which the clip was created.
            /// </summary>
            public string broadcaster_id { get; set; }

            /// <summary>
            /// Display name corresponding to broadcaster_id.
            /// </summary>
            public string broadcaster_name { get; set; }

            /// <summary>
            /// ID of the user who created the clip.
            /// </summary>
            public string creator_id { get; set; }

            /// <summary>
            /// Display name corresponding to creator_id.
            /// </summary>
            public string creator_name { get; set; }

            /// <summary>
            /// ID of the video from which the clip was created.
            /// </summary>
            public string video_id { get; set; }

            /// <summary>
            /// ID of the game assigned to the stream when the clip was created.
            /// </summary>
            public string game_id { get; set; }

            /// <summary>
            /// Language of the stream from which the clip was created.
            /// </summary>
            public string language { get; set; }

            /// <summary>
            /// Title of the clip.
            /// </summary>
            public string title { get; set; }

            /// <summary>
            /// Number of times the clip has been viewed.
            /// </summary>
            public int view_count { get; set; }

            /// <summary>
            /// Date when the clip was created.
            /// </summary>
            public DateTime created_at { get; set; }

            /// <summary>
            /// URL of the clip thumbnail.
            /// </summary>
            public string thumbnail_url { get; set; }
        }

        /// <summary>
        /// Pagination data type with a cursor property
        /// </summary>
        public Pagination pagination { get; set; }
    }
}