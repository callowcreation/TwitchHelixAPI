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
    /// Response about a specified Twitch users
    /// </summary>
    [Serializable]
    public class GetUsers : Payload<GetUsers.User>
    {
        /// <summary>
        /// Twitch users
        /// </summary>
        [Serializable]
        public class User
        {
            /// <summary>
            /// Twitch User’s ID.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// User’s login name.
            /// </summary>
            public string login { get; set; }

            /// <summary>
            /// User’s display name.
            /// </summary>
            public string display_name { get; set; }

            /// <summary>
            /// User’s type: "staff", "admin", "global_mod", or ""
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// User’s broadcaster type: "partner", "affiliate", or "".
            /// </summary>
            public string broadcaster_type { get; set; }

            /// <summary>
            /// User’s channel description.
            /// </summary>
            public string description { get; set; }

            /// <summary>
            /// URL of the user’s profile image.
            /// </summary>
            public string profile_image_url { get; set; }

            /// <summary>
            /// URL of the user’s offline image.
            /// </summary>
            public string offline_image_url { get; set; }

            /// <summary>
            /// Total number of views of the user’s channel.
            /// </summary>
            public int view_count { get; set; }

            /// <summary>
            /// User’s email address. 
            /// </summary>
            public string email { get; set; }
        }
    }
}