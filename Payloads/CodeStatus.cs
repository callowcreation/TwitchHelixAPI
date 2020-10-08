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

namespace TwitchHelixAPI.Payloads
{
    /// <summary>
    /// Code and user id
    /// </summary>
    [Serializable]
    public class CodeStatus
    {
        /// <summary>
        /// The code to apply action to the authenticated user’s account.
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// Represents a numeric Twitch user ID.
        /// </summary>
        public string status { get; set; }
    }
}
