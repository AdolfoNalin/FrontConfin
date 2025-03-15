using FrontConfin.Helpers;
using FrontConfin.Model;
using FrontConfin.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConfin.View
{
    public partial class frmCity : Form
    {
        private PaginationResponse<City> pagination = null;
        bool _verifiacation = false;

        public frmCity()
        {
            InitializeComponent();
            txtSkip.Text = "1";
            txtTake.Text = "10";
            txtId.Enabled = false;
            UpdateData();
        }

        #region UpdateData
        private async void UpdateData()
        {
            int.TryParse(txtSkip.Text, out int skip);
            int.TryParse(txtTake.Text, out int take);

            pagination = await CityService.GetPagination(txtSearch.Text, take: take, skip: skip, cbDesc.Checked);

            dgCity.DataSource = pagination.Data;
        }
        #endregion

        #region UpdateDatails
        private void UpdateDatails()
        {
            City city = new City();

            if (dgCity.SelectedRows.Count > 0)
            {
                city = (City)dgCity.SelectedRows[0].DataBoundItem;

                txtId.Text = city.Id.ToString();
                cbState.Text = city.StateSigla;
                txtName.Text = city.Name;
            }
        }
        #endregion

        #region frmCity_Load
        private async void frmCity_Load(object sender, EventArgs e)
        {
            List<State> list = new List<State>();
            list = await StateService.GetAll();

            cbState.DataSource = list.Select(s => s.Sigla).ToList();
        }
        #endregion

        #region btnNew_click
        private void btnNew_Click(object sender, EventArgs e)
        {
            _verifiacation = false;
            TabControl1.SelectedTab = tpDatails;

            cbState.Text = String.Empty;
            txtName.Clear();

            txtName.Focus();
        }
        #endregion

        #region btnSave_click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool value = false;
            try
            {
                City city = new City()
                {
                    StateSigla = cbState.Text ?? throw new ArgumentNullException("A cidade precisa de uma sigla de estado!"),
                    Name = txtName.Text ?? throw new ArgumentNullException("Cidade precisa de um nome!"),
                };

                if (city is null)
                {
                    throw new NullReferenceException("Cidade não pode ser nulo");
                }

                if (_verifiacation)
                {
                    city.Id = Guid.Parse(txtId.Text.ToString());
                    value = await CityService.Put(city);
                }
                else
                {
                    value = await CityService.Post(city);
                }


                if (value)
                {
                    TabControl1.SelectedTab = tpRegistration;
                    UpdateData();
                }
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region dgCity_SelectionChanged
        private void dgCity_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDatails();
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _verifiacation = true;
            txtId.Enabled = false;
            TabControl1.SelectedTab = tpDatails;
        }
        #endregion

        #region btnDelete_click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Guid.TryParse(txtId.Text, out Guid id);
                bool value = await CityService.Delete(id);

                if (value)
                {
                    TabControl1.SelectedTab = tpRegistration;
                    UpdateData();
                }
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion

        #region frmCity_KeyDown
        private void frmCity_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateData();
        }
        #endregion

        #region btnPrimaryKey_Click
        private void btnPrimary_Click(object sender, EventArgs e)
        {
            if (pagination.Skip > 1)
            {
                txtSkip.Text = "1";
                UpdateData();
            }
            else
            {
                MessageBox.Show("Impossivel voltar para a primeira página");
            }
        }
        #endregion

        #region btnEnd_Click
        private void btnEnd_Click(object sender, EventArgs e)
        {
            decimal page = pagination.AllLine / pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (pagination.Skip < amountPage)
            {
                txtSkip.Text = pagination.Skip.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Não há proxima página");
            }
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tpRegistration;
            UpdateData();
        }
        #endregion

        #region btnNext_Click
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
                MessageBox.Show("Impossivel ir para a proxima página");
            }
        }
        #endregion

        #region btnPrevious_Click
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
                MessageBox.Show("Impossivel ir para a página 0");
            }
        }
        #endregion

        #region cbDesc_CheckedChanged
        private void cbDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateData();
        }
    }
}
