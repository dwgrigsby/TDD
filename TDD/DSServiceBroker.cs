using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace TDD
{
    class DSServiceBroker
    {
        public dsResponse CallDSAPI(dsParameters callParameters)
        {
            dsResponse responseFromServer = new dsResponse();

            string requestURI = callParameters.restEndpoint + callParameters.dsmethodURI;
            try
            {
                WebRequest webRequest = WebRequest.Create(requestURI);

                webRequest.Headers.Add("X-DocuSign-Authentication", DSUtilities.XDSAuthHeaderValue(callParameters.userName, callParameters.password, callParameters.integratorKey));
                webRequest.Method = "GET";

                WebResponse response = webRequest.GetResponse();


                responseFromServer.responseCode = (((HttpWebResponse)response).StatusCode.ToString());
                responseFromServer.responseOK = true;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                responseFromServer.response = reader.ReadToEnd();

                response.Close();
            }
            catch(WebException ex)
            {
                responseFromServer.responseOK = false;
                responseFromServer.responseError = ex.Message;
                responseFromServer.responseErrorResponse = ex.Response.ToString();
            }
            finally
            {

            }

            return responseFromServer;
        }
    }
}
