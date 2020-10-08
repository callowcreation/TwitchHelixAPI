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
    /// Pagination data type with a cursor property
    /// </summary>
    [Serializable]
    public class Pagination
    {
        /// <summary>
        /// Cursor indicating when to start the next query to return more data
        /// </summary>
        public string cursor { get; set; }
    }
}
