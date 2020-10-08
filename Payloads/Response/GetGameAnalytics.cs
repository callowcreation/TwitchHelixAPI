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
    /// Gets a URL that game developers can use to download analytics reports (CSV files) for their games. 
    /// </summary>
    [Serializable]
    public class GetGameAnalytics : Payload<GetGameAnalytics.GameAnalytics>
    {
        /// <summary>
        /// Game analytics reports
        /// </summary>
        [Serializable]
        public class GameAnalytics
        {
            /// <summary>
            /// ID of the game whose analytics data is being provided.
            /// </summary>
            public string game_id { get; set; }

            /// <summary>
            /// URL to the downloadable CSV file containing analytics data.
            /// <para>Valid for 5 minutes.</para>
            /// </summary>
            public string URL { get; set; }

            /// <summary>
            /// Type of report.
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// The date range of the request
            /// </summary>
            public DateRange date_range { get; set; }
        }

        /// <summary>
        /// Pagination data type with a cursor property
        /// </summary>
        public Pagination pagination { get; set; }
    }
}