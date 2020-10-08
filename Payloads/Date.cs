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
    /// String to date conversion
    /// </summary>
    public static class Date
    {
        /// <summary>
        /// String to date conversion
        /// <para>ie. 2018-02-05T08:00:00Z</para>
        /// </summary>
        /// <param name="dateString">ie. 2018-02-05T08:00:00Z</param>
        /// <returns></returns>
        public static DateTime AsDateTime(string dateString)
        {
            if (string.IsNullOrWhiteSpace(dateString)) return default(DateTime);
            return DateTime.Parse(dateString);
        }
    }
}
