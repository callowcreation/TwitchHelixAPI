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
    /// A URL where you can upload a manifest file and notify users that they have an entitlement.
    /// </summary>
    [Serializable]
    public class CreateEntitlementGrantsUploadURL : Payload<CreateEntitlementGrantsUploadURL.EntitlementGrantsUploadURL>
    {
        /// <summary>
        /// A URL where you can upload a manifest file and notify users that they have an entitlement.
        /// </summary>
        [Serializable]
        public class EntitlementGrantsUploadURL
        {
            /// <summary>
            /// The URL where you will upload the manifest file. This is the URL of a pre-signed S3 bucket. Lease time: 15 minutes.
            /// </summary>
            public string url { get; set; }
        }
    }
}