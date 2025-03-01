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
    public partial class frmInsertState : Form
    {

        private PaginationResponse<State> pagination = null;

        public frmInsertState()
        {
            InitializeComponent();
            txtSkip.Text = "1";
            txtTake.Text = "10";
            UpdateData();
        }

        private bool _verification = false;

        #region btnExit_click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region UpdateData
        /// <summary>
        /// Metodo que autaliza a os dados do DataGrid
        /// </summary>
        private async void UpdateData()
        {
            int.TryParse(txtSkip.Text, out int skip);
            int.TryParse(txtTake.Text, out int take);

            pagination = await StateService.GetPagination(txtSearch.Text, skip: skip, take: take, desc: cbDesc.Checked);

            dgState.DataSource = pagination.Data;
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _verification = false;
            txtAcronym.ReadOnly = true;
            TabControl1.SelectedTab = tpDatails;
            txtAcronym.Focus();
        }
        #endregion

        #region btnSave_click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                State state = new State()
                {
                    Name = txtName.Text ?? throw new ArgumentNullException("Nome não pode ser vázio!"),
                    Sigla = txtAcronym.Text ?? throw new ArgumentNullException("sigla não pode ser vázio!")
                };

                if (state is null)
                {
                    throw new NullReferenceException("Estado está sem nome e sigla");
                }

                var result = _verification ? await StateService.Post(state) : await StateService.Put(state);

                if (result)
                {
                    TabControl1.SelectedTab = tpRegistration;
                }

                UpdateData();
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnNew_click
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                _verification = true;
                TabControl1.SelectedTab = tpDatails;

                txtAcronym.Clear();
                txtName.Clear();

                txtAcronym.Focus();

            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnSearch_click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion

        #region frmInsertSate_KeyDown
        private void frmInsertState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
        #endregion

        #region btnPrimaryKey_clikc
        private void btnPrimary_Click(object sender, EventArgs e)
        {
            if (pagination.Skip > 1)
            {
                txtSkip.Text = "1";
                UpdateData();
            }
            else
            {
                MessageBox.Show("Impossivel voltar para á primeira pagina!");
            }
        }
        #endregion

        #region btnPrevious_click
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagination.Skip > 1)
            {
                pagination.Skip--;
                txtSkip.Text = pagination.Skip.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Impossivel voltar para página 0");
            }
        }
        #endregion

        #region btnNext_click
        private void btnNext_Click(object sender, EventArgs e)
        {
            decimal page = pagination.AllLine / pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (pagination.Skip < amountPage)
            {
                pagination.Skip++;
                txtSkip.Text = pagination.Skip.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Impossivel ir para próxima página 0");
            }
        }
        #endregion

        #region btnEnd_click
        private void btnEnd_Click(object sender, EventArgs e)
        {
            decimal page = pagination.AllLine / pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (pagination.Skip < amountPage)
            {
                txtSkip.Text = amountPage.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Não há próxima página  ");
            }
        }
        #endregion

        #region UpdateDetails
        private void UpdateDetails()
        {
            State state = new State();

            if (dgState.SelectedRows.Count > 0)
            {
                state = (State)dgState.SelectedRows[0].DataBoundItem;

                txtAcronym.Text = state.Sigla;
                txtName.Text = state.Name;
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

        #region dgState_SelectionChanged
        private void dgState_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }
        #endregion
        
        #region btnDelete_click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            State state = new State();

            if (dgState.SelectedRows.Count > 0)
            {
                state = (State)dgState.SelectedRows[0].DataBoundItem;

                DialogResult resp = MessageBox.Show($"Deja excluir esse estado {state.Sigla}", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resp == DialogResult.OK)
                {
                    bool result = await StateService.Delete(state.Sigla);

                    if (result)
                    {
                        UpdateData();
                    }
                }
            }
        }
        #endregion

        private void frmInsertState_Load(object sender, EventArgs e)
        {

        }
    }
}
