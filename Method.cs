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

namespace TwitchHelixAPI
{
    /// <summary>
    /// Method type of the request 
    /// </summary>
    public struct Method
    {
        /// <summary>
        /// Represent a GET request
        /// <para>Retrieves information for the server</para>
        /// </summary>
        public const string GET = "GET";

        /// <summary>
        /// Represent a PUT request
        /// <para>Changes information on the server</para>
        /// </summary>
        public const string PUT = "PUT";

        /// <summary>
        /// Represent a POST request
        /// <para>Changes information on the server</para>
        /// </summary>
        public const string POST = "POST";

        /// <summary>
        /// Represent a PATCH request
        /// <para>Changes information on the server</para>
        /// </summary>
        public const string PATCH = "PATCH";

        /// <summary>
        /// Represent a DELETE request
        /// <para>Changes information on the server</para>
        /// </summary>
        public const string DELETE = "DELETE";
    }
}