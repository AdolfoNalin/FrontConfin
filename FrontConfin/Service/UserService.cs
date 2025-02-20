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

				var endpoint = Helpers.Endpoint.GetEndpoint();

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

        #region GetAll
		public async Task<List<User>> GetAll()
		{
			List<User> list = new List<User>();
			try
			{
				HttpClient client = Helpers.ClientHttp.CreateHttpClient();
				HttpResponseMessage response = await client.GetAsync("User");

				if(response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<User>>(await response.Content.ReadAsStringAsync() ?? throw new ArgumentNullException("Lista está vazia!"));
				}
				else
				{
					string message = await response.Content.ReadAsStringAsync();
					MessageBox.Show(message);
				}

				return list;
			}
			catch(ArgumentNullException ae)
			{
				MessageBox.Show(ae.Message);
				return null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}
        #endregion

        #region Post
		public async Task<bool> Post(User user)
		{
			bool value = false;
			try
			{
				HttpClient client = Helpers.ClientHttp.CreateHttpClient();
				HttpResponseMessage response = await client.PostAsJsonAsync("User", user);

				if(response.IsSuccessStatusCode)
				{
					value = true;
					MessageBox.Show(await response.Content.ReadAsStringAsync());
				}
				else
				{
					MessageBox.Show(await response.Content.ReadAsStringAsync());
				}

				return value;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
        #endregion
    }
}
