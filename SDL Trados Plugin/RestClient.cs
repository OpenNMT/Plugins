using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace OpenNMT
{
    public class RestClient
    {
        public RestClient(string serverAddress, int serverPort)
        {
            uri = "http://" + serverAddress + ":" + Convert.ToString(serverPort) + "/translate";
        }

        private enum httpMethod
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        private string uri;

        public string getTranslation(string sourceString, List<string> features)
        {
            string responseJson = string.Empty;
            string translation = string.Empty;


            TextField Source = new TextField
            {
                Text = sourceString + string.Join("",features.ToArray())
            };

            Request SourceRequest = new Request
            {
                SourceText = new TextField[] { Source }
            };




            string serializedSourceString = JsonConvert.SerializeObject(SourceRequest);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = httpMethod.POST.ToString();
            request.ContentType = "application/json";
            
            //We need to close and open the connection every time to avoid
            //errors with unfinished requests
            request.KeepAlive = false;
            
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(serializedSourceString);
                streamWriter.Flush();
                streamWriter.Close();
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Error code: " + response.StatusCode.ToString());
                }
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            responseJson = reader.ReadToEnd();
                        }
                    }
                }
            }

            Response Target = JsonConvert.DeserializeObject<Response>(responseJson);

            translation = Target.TargetText[0][0].Text;
            
            //translation = jsonTranslation[0][0].SelectToken("tgt").ToString();
            return translation;
        }
    }

    
    public class TextField
    {

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Request
    {
        [JsonProperty("src")]
        public TextField[] SourceText { get; set; }
    }

    public class Response
    {
        [JsonProperty("tgt")]
        public TextField[][] TargetText { get; set; }
    }

    

   

}