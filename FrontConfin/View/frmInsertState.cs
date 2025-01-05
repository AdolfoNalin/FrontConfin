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
    public partial class frmInsertState : Form
    {
        public frmInsertState()
        {
            InitializeComponent();
        }

        #region btnExit_click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
