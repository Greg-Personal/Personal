using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace GenericConsoleApp
{
    class Program
    {
        public Uri PeteServerUri = new Uri("http://192.168.183.128:3000");

        static void Main(string[] args)
        {
            JObject test = JObject.Parse(@"{'settings': {'SSIDs': ['CAA','CAA-Guest']}}");
            //JObject test = JObject.Parse(@"{'SSIDs': ['CAA','CAA-Guest']}");
            //string test = "{\"settings\": {\"SSIDs\":[\"CAA\",\"CAA-Guest\"]}}";
            //var testDict = new Dictionary<string, object>();
            //testDict = Helpers.JsonDictParse(test);
            List<string> SSIDs = test["settings"]["SSIDs"].Select(t => (string)t).ToList();

            Console.ReadKey();

        }

        public Dictionary<string, object> GetServiceSettings(string ServiceID)
        {
            var service = Helpers.JsonDictParse(SendRequest("GET", String.Format(Helpers.Path.ServiceById, ServiceID)));
            if (service.ContainsKey("settings"))
            {
                return Helpers.JsonDictParse((string)service["settings"]);
            }
            else
            {
                return new Dictionary<string, object>();
            }
        }

        public string SendRequest(string HttpMethod, string Path, System.Net.HttpStatusCode ExpectedResponse = HttpStatusCode.OK, string ReqBody = null, Dictionary<string, string> QueryParams = null)
        {

            var reqUri = QueryParams == null ? Helpers.UriFromPath(PeteServerUri, Path) : Helpers.UriFromPath(PeteServerUri, Path, QueryParams);
            var req = (HttpWebRequest)WebRequest.Create(reqUri);
            req.UserAgent = "PETE V1Client 1.0";
            req.Accept = "application/json";
            req.Method = HttpMethod;
            req.Timeout = 20000;

            if ((HttpMethod == "POST" || HttpMethod == "PUT" || HttpMethod == "PATCH") && ReqBody != null)
            {
                var reqStream = req.GetRequestStream();
                var payload = Encoding.UTF8.GetBytes(ReqBody);
                reqStream.Write(payload, 0, payload.Length);
                reqStream.Close();
                req.ContentType = "application/json";
            }
            var res = (HttpWebResponse)req.GetResponse();
            if (res.StatusCode == ExpectedResponse)
            {
                using (var sr = new StreamReader(res.GetResponseStream()))
                {
                    string responseString = sr.ReadToEnd();
                    res.Close();
                    return responseString;
                }
            }
            else
            {
                throw new Exception(String.Format("Unexpected response status: {0}", res.StatusCode));
            }
        }
    }

    class Helpers
    {
        public struct Path
        {
            public const string Services = "/services";
            public const string ServiceById = "/services/{0}";
            public const string Nodes = "/services/{0}/nodes";
            public const string NodeById = "/services/{0}/nodes/{1}";
            public const string NodeStatus = "/services/{0}/nodes/{1}/status";
        }

        public static Uri UriFromPath(Uri PeteServerUri, string Path, Dictionary<string, string> queryParams = null)
        {
            if (queryParams != null)
            {
                Path += "?" + String.Join("&",
                    queryParams.Select<KeyValuePair<string, string>, string>(
                        p => String.Format("{0}={1}", p.Key, p.Value)));
            }
            return new Uri(PeteServerUri, Path);
        }

        public static Dictionary<string, object> JsonDictParse(string JsonDict)
        {
            var parsedObj = (JObject)JsonConvert.DeserializeObject(JsonDict);
            var retObj = new Dictionary<string, object>();
            foreach (var item in parsedObj)
            {
                retObj.Add(item.Key.ToString(), item.Value);
            }
            return retObj;
        }

        public static List<string> JsonArrayParse(string JsonDict)
        {
            var parsedObj = (JArray)JsonConvert.DeserializeObject(JsonDict);
            var retObj = new List<string>();
            foreach (var item in parsedObj)
            {

                retObj.Add(item.ToString());
            }
            return retObj;
        }
    }
}
