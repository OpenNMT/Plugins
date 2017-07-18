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
            uri = "http://" + serverAddress + ":" + Convert.ToString(serverPort) + "/translator/translate";
        }

        private enum httpMethod
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        private string uri;

        public string getTranslation(string sourceString)
        {
            string responseJson = string.Empty;
            string translation = string.Empty;

            List <JsonTranslationResponse> ListJson = new List<JsonTranslationResponse>();
            JsonTranslationResponse JsonTranslation = new JsonTranslationResponse();
            
            JsonTranslation.src = sourceString;
            ListJson.Add(JsonTranslation);

            string serializedSourceString = JsonConvert.SerializeObject(ListJson);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = httpMethod.POST.ToString();
            request.ContentType = "application/json";
            
            //request.KeepAlive = true;

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

            //We can't deserialize with JsonConvert.DeserializeObject because 
            //the json returned is a two dimensional array but the json request is 
            //serialized as a signle-dimensional array
            JArray jsonTranslation = JArray.Parse(responseJson);
            translation = jsonTranslation[0][0].SelectToken("tgt").ToString();
            return translation;
        }
    }


    //The json returned from the server. We ignore everything except from
    //src so we can serialize correctly.
    public class JsonTranslationResponse
    {

        [JsonIgnore]
        public string tgt { get; set; }

        public string src { get; set; }
        [JsonIgnore]
        public float pred_score { get; set; }
        [JsonIgnore]
        public int n_best { get; set; }
    }


    

   

}