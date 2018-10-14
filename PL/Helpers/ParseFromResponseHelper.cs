using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace PL.Helpers
{
    public static class ParseFromResponseHelper
    {
        private static readonly string host = "http://localhost:9090/api/";

        public static T GetObject<T>(string api)
        {
            var request = WebRequest.Create(host + api);
            var response = request.GetResponse();

            string responseString;
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                responseString = streamReader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<T>(responseString);
        }

        public static void PutObject<T>(string api, T data)
        {
            Action(api, data, "PUT");
        }

        public static void DeleteObject<T>(string api, T data)
        {
            Action(api, data, "DELETE");
        }

        public static void PostObject<T>(string api, T data)
        {
            Action(api, data, "POST");
        }

        private static void Action<T>(string api, T data, string action)
        {
            var request = WebRequest.Create("http://localhost:9090/api/" + api);

            var json = new JavaScriptSerializer().Serialize(data);

            request.Method = action;
            request.ContentType = "application/json";
            request.ContentLength = json.Length;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}