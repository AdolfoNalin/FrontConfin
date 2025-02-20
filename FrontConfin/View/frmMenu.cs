using FrontConfin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConfin.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            lblUser.Text += UserSession.Name;
            PermissonUser();
        }

        #region PermissonUser
        private void PermissonUser()
        {
            usuárioToolStripMenuItem.Enabled = false;

            if (UserSession.Function.ToUpper() == "Gerente".ToUpper())
            {
                usuárioToolStripMenuItem.Enabled = true;
            }
        }
        #endregion

        #region btnSair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertState screen = new frmInsertState();
            screen.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCity screem = new frmCity();
            screem.ShowDialog();
            screem.Close();
        }
    }
}
