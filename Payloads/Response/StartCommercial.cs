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
    /// Commercial started on a specified channel.
    /// </summary>
    [Serializable]
    public class StartCommercial : Payload<StartCommercial.Commercial>
    {
        /// <summary>
        /// Commercial length and message
        /// </summary>
        [Serializable]
        public class Commercial
        {
            /// <summary>
            /// Length of the triggered commercial
            /// </summary>
            public int length { get; set; }

            /// <summary>
            /// Provides contextual information on why the request failed
            /// </summary>
            public string message { get; set; }

            /// <summary>
            /// Seconds until the next commercial can be served on this channel
            /// </summary>
            public int retry_after { get; set; }
        }
    }
}