using FrontConfin.Model;
using FrontConfin.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConfin.View
{
    public partial class frmAccount : Form
    {
        private PaginationResponse<Account> _pagination = null;
        private bool _isUpdate = false;
        
        public frmAccount()
        {
            InitializeComponent();
            txtId.Enabled = false;
            txtSkip.Text = "1";
            txtTake.Text = "10";
            UpdateData();
        }

        #region Update Data
        public async void UpdateData()
        {
            int.TryParse(txtSkip.Text, out int skip);
            int.TryParse(txtTake.Text, out int take);

            _pagination = await AccountService.GetPagination(txtSearch.Text, skip: skip, take: take, cbDesc.Checked);

            dgAccount.DataSource = _pagination.Data;
        }
        #endregion

        #region UpdateDatails
        public void UpdateDatails()
        {
            Account account = new Account();

            if (dgAccount.SelectedRows.Count > 0)
            {
                account = (Account)dgAccount.SelectedRows[0].DataBoundItem;

                txtId.Text = account.Id.ToString();
                txtDescription.Text = account.Description;
                mtbDateDue.Text = account.DueDate.ToString();
                mtbPaymentDate.Text = account.PaymentDate.ToString();
                mtbValue.Text = account.Value.ToString();
                cbSituation.Text = account.Situation.ToString();
            }
        }
        #endregion

        #region dgAccount_SelectionChanged
        private void dgAccount_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDatails();
        }
        #endregion

        #region btnSave_click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool value = false;

            Account account = new Account()
            {
                PersonaId = Guid.Parse(cbPersona.SelectedValue.ToString()),
                Description = txtDescription.Text,
                DueDate = DateTime.Parse(mtbDateDue.Text),
                PaymentDate = mtbPaymentDate.Text.Contains("_") ? DateTime.Parse(mtbPaymentDate.Text) : null,
                Value = float.Parse(mtbValue.Text),
                Situation = cbSituation.Equals("close") ? Situation.close : Situation.open
            };

            if (_isUpdate)
            {
                account.Id = Guid.Parse(txtId.Text);
                value = await AccountService.Put(account);
            }
            else
            {
                value = await AccountService.Post(account);
            }

            if (value)
            {
                UpdateData();
                TabControl1.SelectedTab = tpRegistration;
            }
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _isUpdate = true;
            UpdateDatails();
            TabControl1.SelectedTab = tpDatails;
        }
        #endregion

        #region btnNew_Click
        private void btnNew_Click(object sender, EventArgs e)
        {
            _isUpdate = false;

            txtId.Text = String.Empty;
            txtDescription.Text = String.Empty;
            mtbDateDue.Text = String.Empty;
            mtbPaymentDate.Text = String.Empty;
            mtbValue.Text = String.Empty;
            cbSituation.Text = String.Empty;

            txtDescription.Focus();

            TabControl1.SelectedTab = tpDatails;
        }
        #endregion

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Account account = (Account)dgAccount.SelectedRows[0].DataBoundItem;

            bool value = await AccountService.Delete(account.Id);

            if (value)
            {
                TabControl1.SelectedTab = tpRegistration;
                UpdateData();
            }
        }
        #endregion

        #region btnCancel_click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tpRegistration;
            UpdateData();
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region cbDesc_CheckedChanged
        private void cbDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion

        #region txtSearch_KeyPress
        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Account> list = new List<Account>();
            list = await AccountService.GetSearch(txtSearch.Text);

            dgAccount.DataSource = list;

            if (e.KeyChar == 13)
            {
                btnSearch_Click(sender, e);
            }
        }
        #endregion

        #region btnSearch_Click
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            List<Account> list = new List<Account>();
            list = await AccountService.GetSearch(txtSearch.Text);

            dgAccount.DataSource = list;
        }
        #endregion

        #region btnPrimary_Click
        private void btnPrimary_Click(object sender, EventArgs e)
        {
            if (dgAccount.Rows.Count > 1)
            {
                txtSkip.Text = "1";
                UpdateData();
            }
            else
            {
                MessageBox.Show("Você já está na primeira página");
            }
        }
        #endregion

        #region btnEnd_Click
        private void btnEnd_Click(object sender, EventArgs e)
        {
            decimal page = _pagination.Skip / _pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (_pagination.Take < amountPage)
            {
                txtTake.Text = amountPage.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Você já está na ultima página");
            }
        }
        #endregion

        #region btnPrevious_Click
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_pagination.Skip > 1)
            {
                _pagination.Skip--;
                txtSkip.Text = _pagination.Skip.ToString();
            }
            else
            {
                MessageBox.Show("Você já está na primeira página");
            }
        }
        #endregion

        #region btnNext_click
        private void btnNext_Click(object sender, EventArgs e)
        {
            decimal page = _pagination.Skip / _pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (_pagination.Skip < amountPage)
            {
                _pagination.Skip++;
                txtSkip.Text = _pagination.Skip.ToString();
            }
            else
            {
                MessageBox.Show("Você já está na ultima página");
            }
        }
        #endregion

        #region Load
        private async void frmAccount_Load(object sender, EventArgs e)
        {
            List<Persona> list = new List<Persona>();
            list = await PersonaService.GetAll();

            cbPersona.DataSource = list;
            cbPersona.ValueMember = "id";
            cbPersona.DisplayMember = "name";
        }
        #endregion
    }
}
