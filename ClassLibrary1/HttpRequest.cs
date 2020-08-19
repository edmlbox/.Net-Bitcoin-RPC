using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
namespace BitcoinRpc
{
    class HttpRequest
    {
       
         BitcoinClient bitcoinClient;
         HttpClient httpClient;
         HttpRequestMessage httpRequestMessage;
         byte[] byteArrayPassword;
         string base64;

        public HttpRequest(BitcoinClient bitcoinClient)
        {
            this.bitcoinClient = bitcoinClient;

            httpClient = new HttpClient();
            httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, bitcoinClient.NodeAddress);
            httpClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            byteArrayPassword = Encoding.ASCII.GetBytes(bitcoinClient.UserPassword);
            base64 = Convert.ToBase64String(byteArrayPassword);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64);

        }
        public async Task<string> SendReq(string methodName, object guesType = null)
        {

            try {
                //HttpRequestMessage must be set to a new instance each time request is sent,
                //otherwise you will get an error: "The request message was already sent. Cannot send the same request message multiple times."
                httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, bitcoinClient.NodeAddress);
                /*-----------------------------------------------------------------------------*/

                string JsonRequestBody = new JsonHandler().JsonWriter(methodName, guesType);

                //Store the request in a static field. For debug purpose.
                Debug.JsonRequest.SerializedJson = JsonRequestBody;
                byte[] jsonByteContent = Encoding.ASCII.GetBytes(JsonRequestBody);

                httpRequestMessage.Content = new ByteArrayContent(jsonByteContent);

                HttpResponseMessage response = await httpClient.SendAsync(httpRequestMessage);

                string responseString = await response.Content.ReadAsStringAsync();

                object deserializedResponse = System.Text.Json.JsonSerializer.Deserialize(responseString, typeof(object));
                string formattedResponse = JsonSerializer.Serialize(deserializedResponse, typeof(object), new JsonSerializerOptions() { WriteIndented = true });
               
                
                
                
                return formattedResponse;

            }
            catch (Exception ex) {
                return ex.Message;
            }



        }
    }
}
