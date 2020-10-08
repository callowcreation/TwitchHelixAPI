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
    /// Creates a marker in the stream of a user specified by user ID
    /// </summary>
    [Serializable]
    public class CreateStreamMarker : Payload<CreateStreamMarker.Marker>
    {
        /// <summary>
        /// A marker is an arbitrary point in a stream that the broadcaster wants to mark; e.g., to easily return to later.
        /// </summary>
        [Serializable]
        public class Marker
        {
            /// <summary>
            /// Unique ID of the marker.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// RFC3339 timestamp of the marker.
            /// </summary>
            public string created_at { get; set; }

            /// <summary>
            /// Description of the marker.
            /// </summary>
            public string description { get; set; }

            /// <summary>
            /// Relative offset (in seconds) of the marker, from the beginning of the stream.
            /// </summary>
            public string position_seconds { get; set; }
        }
    }
}
