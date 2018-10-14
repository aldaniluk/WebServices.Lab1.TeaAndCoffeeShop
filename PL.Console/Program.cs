using BLL.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using SC = System.Console;

namespace PL.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = GetObject<CoffeeBll>("Coffee?id=" + "15E6D3A4-F624-4479-9579-1944ADF33E33");
            coffee.Description = coffee.Description + "...";
            UpdateObject<CoffeeBll>("Coffee/Update", coffee);
        }

        public static T GetObject<T>(string api)
        {
            var request = WebRequest.Create("http://localhost:9090/api/" + api);
            var response = request.GetResponse();

            string responseString;
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                responseString = streamReader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<T>(responseString);
        }

        public static void UpdateObject<T>(string api, T data)
        {
            var request = WebRequest.Create("http://localhost:9090/api/" + api);

            var json = new JavaScriptSerializer().Serialize(data);

            request.Method = "PUT";
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
