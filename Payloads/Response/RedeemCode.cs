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
    /// Redeems one or more provided Bits codes to the authenticated Twitch user. 
    /// </summary>
    [Serializable]
    public class RedeemCode : Payload<CodeStatus>{ }
}