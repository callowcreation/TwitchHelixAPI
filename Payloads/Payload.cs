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
    /// A response that has a data array
    /// </summary>
    /// <typeparam name="T">Type of data to expect</typeparam>
    [Serializable]
    public class Payload<T> : IPayload<T>
    {
        /// <summary>
        /// Expected data type
        /// <para>Each response has an array of the requested item even if only a single item is returned</para>
        /// </summary>
        public T[] data { get; set; }
    }
}
