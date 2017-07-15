using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.IO;

namespace DeriveClassNameSpace.Services.Web
{

    public class HttpRequestResponse
    {
        private string URI;
        private string Request;
        private string UserName;
        private string UserPwd;
        private string ProxyServer;
        private int ProxyPort;
        private string RequestMethod = "GET";

        public HttpRequestResponse(string pRequest,
                             string pURI)//Constructor
        {
            Request = pRequest;
            URI = pURI;
        }

        public string HTTP_USER_NAME
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }

        public string HTTP_USER_PASSWORD
        {
            get
            {
                return UserPwd;
            }
            set
            {
                UserPwd = value;
            }
        }

        public string PROXY_SERVER
        {
            get
            {
                return ProxyServer;
            }
            set
            {
                ProxyServer = value;
            }
        }

        public int PROXY_PORT
        {
            get
            {
                return ProxyPort;
            }
            set
            {
                ProxyPort = value;
            }
        }

        public string SendRequest()
        /*This public interface receives the request 
        and send the response of type string. */
        {
            string FinalResponse = "";
            string Cookie = "";

            NameValueCollection collHeader = new NameValueCollection();

            HttpWebResponse webresponse;

            HttpBaseClass BaseHttp = new
              HttpBaseClass(UserName, UserPwd,
              ProxyServer, ProxyPort, Request);
            try
            {
                HttpWebRequest webrequest =
                  BaseHttp.CreateWebRequest(URI,
                  collHeader, RequestMethod, true);
                webresponse =
                 (HttpWebResponse)webrequest.GetResponse();

                string ReUri =
                  BaseHttp.GetRedirectURL(webresponse,
                  ref Cookie);
                //Check if there is any redirected URI.

                webresponse.Close();
                ReUri = ReUri.Trim();
                if (ReUri.Length == 0) //No redirection URI
                {
                    ReUri = URI;
                }
                RequestMethod = "POST";
                FinalResponse = BaseHttp.GetFinalResponse(ReUri,
                                   Cookie, RequestMethod, true);

            }//End of Try Block


            catch (WebException e)
            {
                throw CatchHttpExceptions(FinalResponse = e.Message);
            }
            catch (System.Exception e)
            {
                throw new Exception(FinalResponse = e.Message);
            }
            finally
            {
                BaseHttp = null;
            }
            return FinalResponse;
        } //End of SendRequestTo method


        private WebException CatchHttpExceptions(string ErrMsg)
        {
            ErrMsg = "Error During Web Interface. Error is: " + ErrMsg;
            return new WebException(ErrMsg);
        }
    }//End of RequestResponse Class

}