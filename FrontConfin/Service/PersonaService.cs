using FrontConfin.Helpers;
using FrontConfin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Service
{
    public class PersonaService
    {
        private static HttpClient _client;

        public PersonaService()
        {
            _client = ClientHttp.CreateHttpClient();
        }

        #region GetAll
        /// <summary>
        /// Mostra todos as pessoas que estão registradas
        /// </summary>
        /// <returns>Retorna uma lista de pessoas</returns>
        public static async Task<List<Persona>> GetAll()
        {
            List<Persona> list = new List<Persona>();
            try
            {
                HttpResponseMessage response = await _client.GetAsync("Persona");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Persona>>(await response.Content.ReadAsStringAsync() ?? throw new Exception("Lista está vazia!"));
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        #region GetPagination
        /// <summary>
        /// Mostra os pessoas de forma paginada
        /// </summary>
        /// <param name="value">Valor para pesquisa</param>
        /// <param name="take">Quantidade de paginas</param>
        /// <param name="skip">Pagina atual</param>
        /// <param name="desc">Ordenar por asc ou desc</param>
        /// <returns>PaginationResponse</returns>
        public static async Task<PaginationResponse<Persona>> GetPagination(string? value, int take, int skip, bool desc)
        {
            PaginationResponse<Persona> pagination = null; 
            try
            {
                HttpClient client = ClientHttp.CreateHttpClient();
                HttpResponseMessage response = await client.GetAsync($"Persona/Pagination?value={value}&skip={skip}&take={take}&desc={desc}");

                if (response.IsSuccessStatusCode)
                {
                    pagination = JsonConvert.DeserializeObject<PaginationResponse<Persona>>(await response.Content.ReadAsStringAsync()) ?? throw new Exception("A Lista está vazia!");
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
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

        #region GetSearch
        /// <summary>
        /// Mostra pessoas de acordo com os o valor de pesquisa
        /// </summary>
        /// <param name="value">Valor para pesquisa</param>
        /// <returns></returns>
        public static async Task<List<Persona>> GetSearch(string value)
        {
            List<Persona> list = new List<Persona>();
            try
            {
                HttpResponseMessage response = await _client.GetAsync($"Search?value={value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Persona>>(await response.Content.ReadAsStringAsync())?? throw new Exception("Lista está vazia!");
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return list;   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        #region Post
        /// <summary>
        /// Cadastra uma pessoa no banco de dados
        /// </summary>
        /// <param name="persona">O objeto Pessoa</param>
        /// <returns></returns>
        public static async Task<bool> Post(Persona persona)
        {
            try
            {
                string message = "";

                HttpResponseMessage response = await _client.PostAsJsonAsync("Persona", persona);

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                    return true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Put
        /// <summary>
        /// Atualiza os dados do Persona
        /// </summary>
        /// <param name="persona">Objeto persona</param>
        /// <returns></returns>
        public static async Task<bool> Put(Persona persona)
        {
            string message = "";
            try
            {
                HttpResponseMessage response = await _client.PutAsJsonAsync("Persona", persona);

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                    return true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta a pessoa do banco de dados
        /// </summary>
        /// <param name="id">Id de identificar</param>
        /// <returns></returns>
        public static async Task<bool> Delete(Guid id)
        {
            string message = "";
            try
            {
                HttpResponseMessage response = await _client.DeleteAsync($"Persona/{id}"); message = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    message += await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                    return true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                    return false;
                }
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
