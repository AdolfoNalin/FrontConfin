using FrontConfin.Helpers;
using FrontConfin.Model;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Service
{
    public class StateService
    {
        #region GetAll
        public async static Task<List<State>> GetAll()
        {
            List<State> list = new List<State>();
            try
            {
                HttpClient client = Helpers.ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync("State");

                if(response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<State>>(await response.Content.ReadAsStringAsync() ?? throw new NullReferenceException("Nenhum estado foi encontrado!"));
                }
                else
                {
                    string content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }

                return list;
            }
            catch(TimeoutException te)
            {
                return null;
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
                return null;
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

        #region GetSearch
        public static async Task<List<State>> GetSearch(string value)
        {
            List<State> list = new List<State>();
            try
            {
                HttpClient client = Helpers.ClientHttp.CreateHttpClient();
                HttpResponseMessage response = await client.GetAsync($"State/Search?value={value}");

                if(response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<State>>(await response.Content.ReadAsStringAsync() ?? throw new NullReferenceException("Lista está vazia, nenhum objeto econtrado"));
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
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
                MessageBox.Show("Aconteceu um erro:{1}",ex.Message);
                return null;
            }
        }
        #endregion

        #region GetPagination
        public static async Task<PaginationResponse<State>> GetPagination(string value, int skip, int take, bool desc)
        {
            PaginationResponse<State> pagination = null;

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();
                HttpResponseMessage response = await client.GetAsync($"State/Pagination?value={value}&skip={skip}&take={take}&desc={desc}");

                if (response.IsSuccessStatusCode)
                {
                    pagination = JsonConvert.DeserializeObject<PaginationResponse<State>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }

                return pagination;
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
                return null;
            }
            catch (ArgumentException ae)
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
        public async static Task<bool> Post(State state)
        {
            bool result = false;   
            try
            {
                if (state is null)
                {
                    throw new NullReferenceException("Sigla ou Nome não pode ser nulas ou vázias");
                }

                HttpClient client = Helpers.ClientHttp.CreateHttpClient();
                client.Timeout = new TimeSpan(0, 0, 30);

                var json = JsonConvert.SerializeObject(state);
                var contentState = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("State", contentState);

                if (response.IsSuccessStatusCode) {
                    result = true;
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                }

                return result;
            }
            catch(ArgumentNullException ae)
            {
                MessageBox.Show($"Aconteceu um erro do típo {ae.Message} com caminho para {ae.StackTrace}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para  {ex.StackTrace}");
                return false;
            }
        }
        #endregion

        #region Put
        public async static Task<bool> Put(State state)
        {
            bool result = false;
            try
            {
                HttpClient client = Helpers.ClientHttp.CreateHttpClient();
                HttpResponseMessage response = await client.PutAsJsonAsync("State", state);

                if(response.StatusCode == HttpStatusCode.OK)
                {
                    result = true;
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }
                else
                {
                   string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return result;
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
                return false;
            }
            catch(ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return false;
            }
        }
        #endregion

        #region Delete
        public async static Task<bool> Delete(string acronym)
        {
            try
            {
                bool value = false;
                HttpClient client = Helpers.ClientHttp.CreateHttpClient();
                HttpResponseMessage response = await client.DeleteAsync($"State/{acronym}");

                if (response.IsSuccessStatusCode)
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