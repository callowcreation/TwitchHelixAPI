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

using Newtonsoft.Json;
using System;

namespace TwitchHelixAPI.Payloads.Response.Analytics
{
    /// <summary>
    /// Gets a URL that extension developers can use to download analytics reports (CSV files) for their extensions.
    /// </summary>
    [Serializable]
    public class GetExtensionAnalytics : Payload<GetExtensionAnalytics.ExtensionAnalytics>
    {
        /// <summary>
        /// Gets a URL that extension developers can use to download analytics reports (CSV files) for their extensions.
        /// </summary>
        [Serializable]
        public class ExtensionAnalytics
        {
            /// <summary>
            /// ID of the extension whose analytics data is being provided.
            /// </summary>
            public string extension_id { get; set; }

            /// <summary>
            /// URL to the downloadable CSV file containing analytics data.
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