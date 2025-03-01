using FrontConfin.Model;
using FrontConfin.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace FrontConfin.View
{
    public partial class frmPersonal : Form
    {
        private PaginationResponse<Persona> _pagination = null;
        private bool _isUpdate = false;

        public frmPersonal()
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

            _pagination = await PersonaService.GetPagination(txtSearch.Text, take: take, skip: skip, cbDesc.Checked);

            dgPersona.DataSource = _pagination.Data;
        }
        #endregion

        #region UpdateDetails
        private void UpdateDatails()
        {
            Persona persona = new Persona();

            if (dgPersona.SelectedRows.Count > 0)
            {
                persona = (Persona)dgPersona.SelectedRows[0].DataBoundItem;

                txtId.Text = persona.Id.ToString();
                txtName.Text = persona.Name;
                txtEmail.Text = persona.Email;
                mtbBirthDate.Text = persona.BirthDate.ToString();
                mtbWage.Text = persona.Wage.ToString();
                cbGender.Text = persona.Gender;
                cbCity.Text = persona.City?.Name;
                cbState.Text = persona.City?.StateSigla;
            }
        }
        #endregion

        #region dgPersona_SelectionChanged
        private void dgPersona_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDatails();
        }
        #endregion

        #region Load
        private async void frmPersonal_Load(object sender, EventArgs e)
        {
            List<string> namesCitys = new List<string>();
            List<City> citys = new List<City>();

            citys = await CityService.GetAll();

            namesCitys = citys.Select(x => x.Name).ToList();

            cbCity.DataSource = namesCitys;
        }
        #endregion

        #region btnUpdate_Click
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

            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            mtbBirthDate.Clear();
            mtbNumberPhone.Clear();
            mtbWage.Clear();

            txtName.Focus();
        }
        #endregion

        #region btnSave_Click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona()
                {
                    Id = Guid.Parse(txtId.Text ?? throw new ArgumentNullException("O canmpo ID não pode ser vázio")),
                    Name = txtName.Text ?? throw new ArgumentNullException("O campo nome não pode ser vázio"),
                    Email = txtEmail.Text ?? throw new ArgumentNullException("O canmpo email não pode ser vázio"),
                    NumberPhone = mtbNumberPhone.Text ?? throw new ArgumentNullException("O canmpo número de celular não pode ser vázio"),
                    BirthDate = DateTime.Parse(mtbBirthDate.Text ?? throw new ArgumentNullException("O canmpo Data de nascimento não pode ser vázio")),
                    Wage = decimal.Parse(mtbWage.Text ?? throw new ArgumentNullException("O canmpo salário não pode ser vázio")),
                    Gender = cbGender.Text ?? throw new ArgumentNullException("O canmpo Gênero não pode ser vázio"),
                }
                ?? throw new Exception("Algo deu errado! verifique se todos os elementos tem o seus valores");

                var result = _isUpdate ? await PersonaService.Put(persona) : await PersonaService.Post(persona);

                if (result)
                {
                    UpdateData();
                    TabControl1.SelectedTab = tpRegistration;
                }
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

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.Parse(txtId.Text ?? throw new ArgumentNullException("O campo id não pode ser vazio!"));

                var result = await PersonaService.Delete(id);

                if (result)
                {
                    UpdateData();
                    TabControl1.SelectedTab = tpRegistration;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        #endregion

        #region btnPrimary_Click
        /// <summary>
        /// Botão que traz a primeira página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrimary_Click(object sender, EventArgs e)
        {
            if (_pagination.Skip > 1)
            {
                txtSkip.Text = "1";
                UpdateData();
            }
            else
            {
                MessageBox.Show("A paginação já está na primeira página");
            }
        }
        #endregion

        #region btnEnd_click
        /// <summary>
        /// Mostra a ultima pagina1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            decimal page = _pagination.AllLine / _pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (_pagination.Skip < amountPage)
            {
                txtSkip.Text = amountPage.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Não existe proxima página");
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
                UpdateData();
            }
            else
            {
                MessageBox.Show("Já está na primeira página");
            }
        }
        #endregion

        #region btnNext_click
        private void btnNext_Click(object sender, EventArgs e)
        {
            decimal page = _pagination.AllLine / _pagination.Take;
            int amountPage = (int)Math.Ceiling(page);

            if (_pagination.Skip > amountPage)
            {
                _pagination.Skip++;
                txtSkip.Text = _pagination.Skip.ToString();
                UpdateData();
            }
            else
            {
                MessageBox.Show("Já está na ultima página");
            }
        }
        #endregion
    }
}
