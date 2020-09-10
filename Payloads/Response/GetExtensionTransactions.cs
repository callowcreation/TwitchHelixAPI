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
    [Serializable]
    public class GetExtensionTransactions : Payload<GetExtensionTransactions.ExtensionTransaction>
    {
        [Serializable]
        public class Cost
        {
            public int amount { get; set; }
            public string type { get; set; }
        }

        [Serializable]
        public class ProductData
        {
            public string sku { get; set; }
            public Cost cost { get; set; }
            public string displayName { get; set; }
            public bool inDevelopment { get; set; }
        }

        [Serializable]
        public class ExtensionTransaction
        {
            public string id { get; set; }
            public DateTime timestamp { get; set; }
            public string broadcaster_id { get; set; }
            public string broadcaster_name { get; set; }
            public string user_id { get; set; }
            public string user_name { get; set; }
            public string product_type { get; set; }
            public ProductData product_data { get; set; }
        }

        public Pagination pagination { get; set; }
    }
}