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
    /// Games sorted by number of current viewers on Twitch, most popular first.
    /// </summary>
    [Serializable]
    public class GetTopGames : Payload<GetTopGames.TopGame>
    {
        /// <summary>
        /// Game name and id and box art url
        /// </summary>
        [Serializable]
        public class TopGame
        {
            /// <summary>
            /// Game ID.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// Game name.
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// Template URL for the game’s box art.
            /// </summary>
            public string boxArtUrl { get; set; }
        }
    }
}