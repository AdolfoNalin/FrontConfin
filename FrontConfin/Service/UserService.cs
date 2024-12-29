using FrontConfin.Model;
using FrontConfin.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FrontConfin.Service
{
    public class UserService
    {
        #region Login
        public static async Task<UserResponse> Login(UserResquest user)
        {
			UserResponse userResponse = new UserResponse();
			try
			{
				if (user is null)
				{
					throw new ArgumentNullException("Login ou senha estão vazio");
				}

				var endpoint = Program.Configuration.GetSection("WFConfin:Endpoint").Value;

				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri(endpoint);
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				client.Timeout = new TimeSpan(0, 0, 30);
				HttpResponseMessage response = await client.PostAsJsonAsync("User/Login", user);

				if (response.StatusCode == HttpStatusCode.OK)
				{
					userResponse = JsonConvert.DeserializeObject<UserResponse>(await response.Content.ReadAsStringAsync());
					return userResponse;
				}
				else
				{
					throw new NullReferenceException("Login inválido!");
				}
				
			}
			catch(ArgumentNullException ae)
			{
				MessageBox.Show(ae.Message);
				return null;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Acoteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
				return null;
			}
        }
        #endregion
    }
}
