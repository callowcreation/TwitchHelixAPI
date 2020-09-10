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
    public class GetTopGames : Payload<GetTopGames.TopGame>
    {
        [Serializable]
        public class TopGame
        {
            public string id { get; set; }
            public string name { get; set; }
            public string box_art_url { get; set; }
        }
    }
}