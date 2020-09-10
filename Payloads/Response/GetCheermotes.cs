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
    public class GetCheermotes : Payload<GetCheermotes.Cheermote>
    {
        /// <summary>
        /// TODO: Implement parser for object
        /// </summary>
        [Serializable]
        public class Actions
        {
            /*
                1.5:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/1.5.gif"
                1:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/1.gif"
                2:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/2.gif"
                3:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/3.gif"
                4:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/4.gif"
            */
        }

        [Serializable]
        public class Images
        {
            public Actions dark { get; set; }
            public Actions light { get; set; }
        }

        [Serializable]
        public class Tier
        {
            public int min_bits { get; set; }
            public string id { get; set; }
            public string color { get; set; }
            public Images images { get; set; }
            public bool can_cheer { get; set; }
            public bool show_in_bits_card { get; set; }
        }

        [Serializable]
        public class Cheermote
        {
            public string prefix { get; set; }
            public Tier[] tiers { get; set; }
            public string type { get; set; }
            public int order { get; set; }
            public DateTime last_updated { get; set; }
            public bool is_charitable { get; set; }
        }
    }
}