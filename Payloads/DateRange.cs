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
    /// The date range of the request
    /// </summary>
    [Serializable]
    public partial class DateRange
    {
        /// <summary>
        /// Timestamp for the period over which the returned data is aggregated.
        /// </summary>
        public string started_at { get; set; }

        /// <summary>
        /// Timestamp for the period over which the returned data is aggregated.
        /// </summary>
        public string ended_at { get; set; }
    }

    /// <summary>
    /// The date range of the request
    /// </summary>
    public partial class DateRange
    {

        /// <summary>
        /// Timestamp for the period over which the returned data is aggregated.
        /// <para>As a date object</para>
        /// </summary>
        public DateTime StartedAt()
        {
            return Date.AsDateTime(started_at);
        }
        
        /// <summary>
        /// Timestamp for the period over which the returned data is aggregated.
        /// <para>As a date object</para>
        /// </summary>
        public DateTime EndedAt()
        {
            return Date.AsDateTime(ended_at);
        }
    }
}
