using FrontConfin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Helpers
{
    public class ClientHttp
    {
        #region CreateHttpClient
        public static HttpClient CreateHttpClient()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Helpers.Endpoint.GetEndpoint());
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserSession.Token);
                client.Timeout = new TimeSpan(0, 0, 30);
                return client;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new HttpClient();
            }
        }   
        #endregion
    }
}
