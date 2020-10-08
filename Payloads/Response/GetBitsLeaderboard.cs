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
    /// A ranked list of Bits leaderboard information for an authorized broadcaster.
    /// </summary>
    [Serializable]
    public class GetBitsLeaderboard : Payload<GetBitsLeaderboard.Leaderboard>
    {
        /// <summary>
        /// Bits leaderboard information for an authorized broadcaster.
        /// </summary>
        [Serializable]
        public class Leaderboard
        {
            /// <summary>
            /// ID of the user (viewer) in the leaderboard entry
            /// </summary>
            public string user_id { get; set; }

            /// <summary>
            /// Display name corresponding to user_id
            /// </summary>
            public string user_name { get; set; }

            /// <summary>
            /// Leaderboard rank of the user.
            /// </summary>
            public int rank { get; set; }

            /// <summary>
            /// Leaderboard score (number of Bits) of the user.
            /// </summary>
            public int score { get; set; }
        }

        /// <summary>
        /// The date range of the request
        /// </summary>
        public DateRange date_range { get; set; }

        /// <summary>
        /// Total number of results (users) returned.
        /// </summary>
        public int total { get; set; }
    }
}