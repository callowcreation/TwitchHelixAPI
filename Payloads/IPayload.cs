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

namespace TwitchHelixAPI.Payloads
{
    /// <summary>
    /// A response that has a data array
    /// <typeparam name="T">Type of data to expect</typeparam>
    /// </summary>
    public interface IPayload<T>
    {
        /// <summary>
        /// The response has a JSON payload with a data field containing an array
        /// </summary>
        T[] data { get; set; }
    }
}
