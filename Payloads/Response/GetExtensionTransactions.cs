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

namespace TwitchHelixAPI.Payloads.Response
{
    /// <summary>
    /// List of transactions that have occurred for their extension across all of Twitch
    /// </summary>
    [Serializable]
    public class GetExtensionTransactions : Payload<GetExtensionTransactions.ExtensionTransaction>
    {
        /// <summary>
        /// JSON Object representing the cost to acquire the product.
        /// </summary>
        [Serializable]
        public class Cost
        {
            /// <summary>
            /// Number of Bits required to acquire the product.
            /// </summary>
            public int amount { get; set; }

            /// <summary>
            /// Always the string “Bits”.
            /// </summary>
            public string type { get; set; }
        }

        /// <summary>
        /// JSON Object representing the product acquired, as it looked at the time of the transaction.
        /// </summary>
        [Serializable]
        public class ProductData
        {
            /// <summary>
            /// Unique identifier for the product across the extension.
            /// </summary>
            public string sku { get; set; }

            /// <summary>
            /// JSON Object representing the cost to acquire the product.
            /// </summary>
            public Cost cost { get; set; }

            /// <summary>
            /// Display Name of the product.
            /// </summary>
            public string displayName { get; set; }

            /// <summary>
            /// Flag used to indicate if the product is in development. Either true or false.
            /// </summary>
            public bool inDevelopment { get; set; }
        }

        /// <summary>
        /// List of transactions that have occurred for their extension across all of Twitch
        /// </summary>
        [Serializable]
        public class ExtensionTransaction
        {
            /// <summary>
            /// Transaction IDs to look up
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// UTC timestamp when this transaction occurred.
            /// </summary>
            public DateTime timestamp { get; set; }

            /// <summary>
            /// Twitch User ID of the channel the transaction occurred on.
            /// </summary>
            public string broadcaster_id { get; set; }

            /// <summary>
            /// Twitch Display Name of the broadcaster.
            /// </summary>
            public string broadcaster_name { get; set; }

            /// <summary>
            /// Twitch User ID of the user who generated the transaction.
            /// </summary>
            public string user_id { get; set; }

            /// <summary>
            /// Twitch Display Name of the user who generated the transaction.
            /// </summary>
            public string user_name { get; set; }

            /// <summary>
            /// Enum of the product type. Currently only BITS_IN_EXTENSION.
            /// </summary>
            public string product_type { get; set; }

            /// <summary>
            /// JSON Object representing the product acquired, as it looked at the time of the transaction.
            /// </summary>
            public ProductData prproduct_dataoductData { get; set; }
        }

        /// <summary>
        /// Pagination data type with a cursor property
        /// </summary>
        public Pagination pagination { get; set; }
    }
}