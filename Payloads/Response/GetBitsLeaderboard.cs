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
    public class GetBitsLeaderboard : Payload<GetBitsLeaderboard.Leaderboard>
    {
        [Serializable]
        public class Leaderboard
        {
            public string user_id { get; set; }
            public string user_name { get; set; }
            public int rank { get; set; }
            public int score { get; set; }
        }
        
        public DateRange date_range { get; set; }
        public int total { get; set; }
    }
}