using FrontConfin.Model;
using FrontConfin.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConfin.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region btnClose
        private async void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region btnLogin
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserResquest login = new UserResquest()
                {
                    Login = txtLogin.Text,
                    Password = txtPassword.Text
                };

                UserResponse response = await UserService.Login(login);

                UserSession.Id = response.User.Id;
                UserSession.Name = response.User.Name;
                UserSession.Login = response.User.Login;
                UserSession.Function = response.User.Function;
                UserSession.Token = response.Token;

                frmMenu screen = new frmMenu();
                this.Hide();
                screen.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region frmLogin_KeyDown
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        #endregion
    }
}
