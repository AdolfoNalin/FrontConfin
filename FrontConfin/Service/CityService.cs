using FrontConfin.Helpers;
using FrontConfin.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Service
{
    public class CityService
    {
        #region GetAll
        public static async Task<List<City>> GetAll()
        {
            List<City> list = new List<City>();

            try
            {
                HttpClient client = Helpers.ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync("City");

                if(response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<City>>(await response.Content.ReadAsStringAsync() ?? throw new NullReferenceException("Nenhuma cidade encontrada"));
                }

                return list;
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
                return null;
            }
            catch(ArgumentException ae)
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

        #region GetSearch
        public static async Task<List<City>> GetSearch(string value)
        {
            List<City> list = new List<City>();
            try
            {
                HttpClient client = Helpers.ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync($"Search?value={value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<City>>(await response.Content.ReadAsStringAsync());
                }

                return list;
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
                return null;
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        #region GetPaginarion
        public static async Task<PaginationResponse<City>> GetPagination(string? value, int take, int skip, bool desc)
        {
            PaginationResponse<City> pagination = new PaginationResponse<City>(new List<City>(), 1, 0, 10);

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();
               
                HttpResponseMessage response = await client.GetAsync($"City/Pagination?value={value}&skip={skip}&take={take}&desc{desc}");

                if (response.IsSuccessStatusCode)
                {
                    pagination = JsonConvert.DeserializeObject<PaginationResponse<City>>(await response.Content.ReadAsStringAsync() ?? throw new NullReferenceException("Lista está vazia, nenhum objeto econtrado"));
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }

                return pagination;
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                return null;
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
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
        public static async Task<bool> Post(City city)
        {
            bool value = false;
            try
            {
                string message = "";

                if(city is null)
                {
                    throw new ArgumentNullException("Cidade está vazia, preencha todos os campos!");
                }

                HttpClient client = Helpers.ClientHttp.CreateHttpClient();
                client.BaseAddress = new Uri("http://localhost:5024/api/");
                client.Timeout = new TimeSpan(1, 0, 0);

                HttpResponseMessage response = await client.PostAsJsonAsync("City", city);

                if (response.IsSuccessStatusCode)
                {
                    value = true;
                    message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return value;
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Put
        public static async Task<bool> Put(City city)
        {
            bool value = false;
            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();
                
                HttpResponseMessage response = await client.PutAsJsonAsync("City",city);

                if (response.IsSuccessStatusCode)
                {
                    value = true;
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
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

        #region Delete
        public static async Task<bool> Delete(Guid id)
        {
            bool value = false;

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage reposn = await client.DeleteAsync($"City/{id}");

                if (reposn.IsSuccessStatusCode)
                {
                    value = true;
                    string message = await reposn.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }
                else
                {
                    string message = await reposn.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }
        #endregion
    }
}
