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
    /// Programmatically created clip
    /// </summary>
    [Serializable]
    public class CreateClip : Payload<CreateClip.Clip>
    {
        /// <summary>
        /// Programmatically created clip
        /// </summary>
        [Serializable]
        public class Clip
        {
            /// <summary>
            /// ID of the clip that was created.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// URL of the edit page for the clip.
            /// </summary>
            public string edit_url { get; set; }
        }
    }
}