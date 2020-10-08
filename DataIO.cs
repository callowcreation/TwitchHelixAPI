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
using System.IO;
using System.Text;

namespace TwitchHelixAPI
{
    /// <summary>
    /// File system storage
    /// </summary>
    public static class DataIO
    {
        /// <summary>
        /// Save object data to the file system
        /// </summary>
        /// <typeparam name="T">Type to serialize</typeparam>
        /// <param name="path">Full path and file name</param>
        /// <param name="response">Object to save</param>
        public static void Save<T>(string path, T response)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(response));
            string encrypted = Convert.ToBase64String(bytes);
            File.WriteAllText(path, encrypted);

            //File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(response));
        }

        /// <summary>
        /// Load an object from the file system
        /// </summary>
        /// <typeparam name="T">Type to deserialize</typeparam>
        /// <param name="path">Full path and file name</param>
        /// <returns></returns>
        public static T Load<T>(string path)
        {
            if (File.Exists(path) == false) return default(T);

            string encrypted = File.ReadAllText(path);

            byte[] bytes;
            string decrypted = string.Empty;
            try
            {
                bytes = Convert.FromBase64String(encrypted);
                decrypted = Encoding.ASCII.GetString(bytes);
            }
            catch (Exception)
            {
                decrypted = string.Empty;
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(decrypted);
            //return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(encrypted);
        }
    }
}
