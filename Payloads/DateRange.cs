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
    [Serializable]
    public partial class DateRange
    {
        public string started_at { get; set; }
        public string ended_at { get; set; }
    }
    
    public partial class DateRange
    {
        public DateTime StartedAt
        {
            get
            {
                return Date.AsDateTime(started_at);
            }
        }

        public DateTime EndedAt
        {
            get
            {
                return Date.AsDateTime(ended_at);
            }
        }
    }
}
