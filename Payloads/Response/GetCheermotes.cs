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
using System.Collections.Generic;

namespace TwitchHelixAPI.Payloads.Response
{
    /// <summary>
    /// The list of available Cheermotes, animated emotes to which viewers can assign Bits, to cheer in chat.
    /// </summary>
    [Serializable]
    public class GetCheermotes : Payload<GetCheermotes.Cheermote>
    {
        static Dictionary<string, string> s_Empty = new Dictionary<string, string>();

        /// <summary>
        /// TODO: Implement parser for object
        /// </summary>
        [Serializable]
        public partial class Actions
        {
            /// <summary>
            /// Animated image sets containing different size image urls
            /// <para>NOTICE: Use GetCheermotes.Actions.Animated() instead</para>
            /// </summary>
            [Obsolete("Use GetCheermotes.Actions.Animated() instead")]
            public dynamic animated { get; set; }

            /// <summary>
            /// Static image sets containing different size image urls
            /// <para>NOTICE: Use GetCheermotes.Actions.Static() instead</para>
            /// </summary>
            [Obsolete("Use GetCheermotes.Actions.Static() instead")]
            public dynamic @static { get; set; }
        }

        /// <summary>
        /// Structure containing both animated and static image sets.
        /// </summary>
        public partial class Actions
        {
            /*
                1.5:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/1.5.gif"
                1:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/1.gif"
                2:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/2.gif"
                3:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/3.gif"
                4:"https://d3aqoihi2n8ty8.cloudfront.net/actions/cheer/dark/animated/1/4.gif"
            */

            /// <summary>
            /// Animated image sets containing different size image urls
            /// </summary>
            /// <returns>Set image size(s) as key and url(s) as value</returns>
            public Dictionary<string, string> Animated()
            {
#pragma warning disable 0618
                return PopulateActions(animated);
#pragma warning restore 0618
            }

            /// <summary>
            /// Static image sets containing different size image urls
            /// </summary>
            /// <returns>Set image size(s) as key and url(s) as value</returns>
            public Dictionary<string, string> Static()
            {
#pragma warning disable 0618
                return PopulateActions(@static);
#pragma warning restore 0618
            }

            static Dictionary<string, string> PopulateActions(dynamic action)
            {
                if (action == null) return s_Empty;

                Newtonsoft.Json.Linq.JObject obj = new Newtonsoft.Json.Linq.JObject(action);

                Dictionary<string, string> items = new Dictionary<string, string>();

                foreach (var item in obj)
                {
                    items.Add(item.Key, item.Value.ToString());
                }

                return items;
            }

        }

        /// <summary>
        /// Structure containing both animated and static image sets, sorted by light and dark.
        /// </summary>
        [Serializable]
        public class Images
        {
            /// <summary>
            /// Structure containing both animated and static image sets for dark mode.
            /// </summary>
            public Actions dark { get; set; }

            /// <summary>
            /// Structure containing both animated and static image sets for light mode.
            /// </summary>
            public Actions light { get; set; }
        }

        /// <summary>
        /// Cheermotes with their metadata
        /// </summary>
        [Serializable]
        public class Tier
        {
            /// <summary>
            /// Minimum number of bits needed to be used to hit the given tier of emote.
            /// </summary>
            public int min_bits { get; set; }

            /// <summary>
            /// ID of the emote tier.
            /// <para>Possible tiers are: 1,100,500,1000,5000, 10k, or 100k</para>
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// Hex code for the color associated with the bits of that tier.
            /// <para>Grey, Purple, Teal, Blue, or Red color to match the base bit type.</para>
            /// </summary>
            public string color { get; set; }

            /// <summary>
            /// Structure containing both animated and static image sets, sorted by light and dark.
            /// </summary>
            public Images images { get; set; }

            /// <summary>
            /// Indicates whether or not emote information is accessible to users.
            /// </summary>
            public bool can_cheer { get; set; }

            /// <summary>
            /// Indicates whether or not we hide the emote from the bits card.
            /// </summary>
            public bool show_in_bits_card { get; set; }
        }

        /// <summary>
        /// Available Cheermotes, animated emotes to which viewers can assign Bits, to cheer in chat.
        /// </summary>
        [Serializable]
        public class Cheermote
        {
            /// <summary>
            /// The name before number (amount) of the cheer
            /// </summary>
            public string prefix { get; set; }

            /// <summary>
            /// An array of Cheermotes with their metadata
            /// </summary>
            public Tier[] tiers { get; set; }

            /// <summary>
            /// Shows whether the emote is global_first_party,  global_third_party, channel_custom, display_only, or sponsored.
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// Order of the emotes as shown in the bits card, in ascending order.
            /// </summary>
            public int order { get; set; }

            /// <summary>
            /// The data when this Cheermote was last updated.
            /// </summary>
            public DateTime last_updated { get; set; }

            /// <summary>
            /// Indicates whether or not this emote provides a charity contribution match during charity campaigns.
            /// </summary>
            public bool is_charitable { get; set; }
        }
    }
}