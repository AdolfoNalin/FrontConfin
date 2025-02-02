using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FrontConfin.Helpers
{
    public class Endpoint
    {
        #region Endpoint
        public static string GetEndpoint()
        {
            try
            {
                string endpoint = Program.Configuration.GetSection("WFConfin:Endpoint").Value ?? throw new ArgumentNullException("Endpoint não encontrado!");
                return endpoint;
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
    }
}