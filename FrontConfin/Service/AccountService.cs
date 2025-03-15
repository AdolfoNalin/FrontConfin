using FrontConfin.Helpers;
using FrontConfin.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConfin.Service
{
    public class AccountService
    {
        #region GetAll
        /// <summary>
        /// Mostra todas as contas
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Account>> GetAll()
        {
            List<Account> list = new List<Account>();

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync("Account");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Account>>(await response.Content.ReadAsStringAsync() ?? throw new ArgumentNullException("A lista está vazia"));
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    list = null;
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

        #region GetSearch
        /// <summary>
        /// Mostra todoas as contas filtradas
        /// </summary>
        /// <param name="value">Valor de filtro</param>
        /// <returns></returns>
        public static async Task<List<Account>> GetSearch(string value)
        {
            List<Account> list = new List<Account>();
            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync($"Account/Search?value={value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Account>>(await response.Content.ReadAsStringAsync() ?? throw new ArgumentNullException("A lista está vazia"));
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
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

        #region GetId
        public static async Task<Account> GetId(Guid id)
        {
            Account account = new Account();
            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync($"Account/{id}");

                if (response.IsSuccessStatusCode)
                {
                    account = JsonConvert.DeserializeObject<Account>(await response.Content.ReadAsStringAsync() ?? throw new ArgumentNullException("Nenhuma conta encontrada!"));
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return account;
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

        #region GetPagination
        public static async Task<PaginationResponse<Account>> GetPagination(string? value, int skip, int take, bool desc)
        {
            PaginationResponse<Account> pagination = null;

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.GetAsync($"Account/Pagination?value={value}&skip={skip}&take={take}&desc={desc}");

                if(response.IsSuccessStatusCode)
                {
                    pagination = JsonConvert.DeserializeObject<PaginationResponse<Account>>(await response.Content.ReadAsStringAsync() ?? throw new ArgumentException("A lista está vazia"));
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return pagination;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        #region Post
        public static async Task<bool> Post(Account account)
        {
            string message = "";
            bool value = false;
            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.PostAsJsonAsync("Account", account);

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                    value = true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                return value;
            }
            catch(ArgumentNullException ae)
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
        public static async Task<bool> Put(Account account)
        {
            string message = "";
            bool value = false;

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();
                HttpResponseMessage response = await client.PutAsJsonAsync("Account", account); 
                
                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                    value = true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                MessageBox.Show(message);

                return value;
            }
            catch (ArgumentNullException ae)
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

        #region Delete
        public static async Task<bool> Delete(Guid id)
        {
            string message = "";
            bool value = false;

            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();

                HttpResponseMessage response = await client.DeleteAsync($"Account/{id}");

                if (response.IsSuccessStatusCode)
                {
                    message += await response.Content.ReadAsStringAsync();
                    value = true;
                }
                else
                {
                    message += await response.Content.ReadAsStringAsync();
                }

                MessageBox.Show(message);

                return value;
            }
            catch (ArgumentNullException ae)
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
    }
}