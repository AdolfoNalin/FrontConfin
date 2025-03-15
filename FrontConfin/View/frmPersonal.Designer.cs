namespace FrontConfin.View
{
    partial class frmPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl1 = new TabControl();
            tpRegistration = new TabPage();
            dgPersona = new DataGridView();
            tpDatails = new TabPage();
            label8 = new Label();
            cbCity = new ComboBox();
            label7 = new Label();
            cbGender = new ComboBox();
            label6 = new Label();
            mtbWage = new MaskedTextBox();
            label5 = new Label();
            mtbBirthDate = new MaskedTextBox();
            label4 = new Label();
            mtbNumberPhone = new MaskedTextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            cbState = new ComboBox();
            txtName = new TextBox();
            lblName = new Label();
            btnAcronym = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            cbDesc = new CheckBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            txtSkip = new TextBox();
            label2 = new Label();
            txtTake = new TextBox();
            label1 = new Label();
            btnEnd = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnPrimary = new Button();
            panel4 = new Panel();
            btnExit = new Button();
            panel3 = new Panel();
            panel7 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panel6 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            TabControl1.SuspendLayout();
            tpRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPersona).BeginInit();
            tpDatails.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Alignment = TabAlignment.Left;
            TabControl1.Controls.Add(tpRegistration);
            TabControl1.Controls.Add(tpDatails);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.ImeMode = ImeMode.NoControl;
            TabControl1.Location = new Point(0, 100);
            TabControl1.Multiline = true;
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(956, 288);
            TabControl1.TabIndex = 10;
            // 
            // tpRegistration
            // 
            tpRegistration.Controls.Add(dgPersona);
            tpRegistration.Location = new Point(27, 4);
            tpRegistration.Name = "tpRegistration";
            tpRegistration.Padding = new Padding(3);
            tpRegistration.Size = new Size(925, 280);
            tpRegistration.TabIndex = 0;
            tpRegistration.Text = "Registros";
            tpRegistration.UseVisualStyleBackColor = true;
            // 
            // dgPersona
            // 
            dgPersona.BackgroundColor = SystemColors.ActiveCaption;
            dgPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPersona.Dock = DockStyle.Fill;
            dgPersona.Location = new Point(3, 3);
            dgPersona.Name = "dgPersona";
            dgPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPersona.Size = new Size(919, 274);
            dgPersona.TabIndex = 0;
            dgPersona.SelectionChanged += dgPersona_SelectionChanged;
            // 
            // tpDatails
            // 
            tpDatails.Controls.Add(label8);
            tpDatails.Controls.Add(cbCity);
            tpDatails.Controls.Add(label7);
            tpDatails.Controls.Add(cbGender);
            tpDatails.Controls.Add(label6);
            tpDatails.Controls.Add(mtbWage);
            tpDatails.Controls.Add(label5);
            tpDatails.Controls.Add(mtbBirthDate);
            tpDatails.Controls.Add(label4);
            tpDatails.Controls.Add(mtbNumberPhone);
            tpDatails.Controls.Add(label3);
            tpDatails.Controls.Add(txtEmail);
            tpDatails.Controls.Add(txtId);
            tpDatails.Controls.Add(lblId);
            tpDatails.Controls.Add(cbState);
            tpDatails.Controls.Add(txtName);
            tpDatails.Controls.Add(lblName);
            tpDatails.Controls.Add(btnAcronym);
            tpDatails.Location = new Point(27, 4);
            tpDatails.Name = "tpDatails";
            tpDatails.Padding = new Padding(3);
            tpDatails.Size = new Size(925, 280);
            tpDatails.TabIndex = 1;
            tpDatails.Text = "Detalhes";
            tpDatails.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 140);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 18;
            label8.Text = "Cidade:";
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(310, 158);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(91, 23);
            cbCity.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 140);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 16;
            label7.Text = "Gênero:";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            cbGender.Location = new Point(176, 158);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(91, 23);
            cbGender.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 140);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 14;
            label6.Text = "Salário:";
            // 
            // mtbWage
            // 
            mtbWage.Location = new Point(30, 158);
            mtbWage.Name = "mtbWage";
            mtbWage.Size = new Size(96, 23);
            mtbWage.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(780, 79);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 12;
            label5.Text = "Data de Nascimento:";
            // 
            // mtbBirthDate
            // 
            mtbBirthDate.Location = new Point(780, 97);
            mtbBirthDate.Mask = "00/00/0000";
            mtbBirthDate.Name = "mtbBirthDate";
            mtbBirthDate.Size = new Size(58, 23);
            mtbBirthDate.TabIndex = 11;
            mtbBirthDate.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(642, 79);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Celular:";
            // 
            // mtbNumberPhone
            // 
            mtbNumberPhone.Location = new Point(642, 97);
            mtbNumberPhone.Mask = "(99) 99999-9999";
            mtbNumberPhone.Name = "mtbNumberPhone";
            mtbNumberPhone.Size = new Size(80, 23);
            mtbNumberPhone.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 83);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtEmail.Location = new Point(418, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.CharacterCasing = CharacterCasing.Upper;
            txtId.Location = new Point(30, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(288, 23);
            txtId.TabIndex = 6;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(36, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // cbState
            // 
            cbState.FormattingEnabled = true;
            cbState.Location = new Point(427, 157);
            cbState.Name = "cbState";
            cbState.Size = new Size(46, 23);
            cbState.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtName.Location = new Point(30, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(36, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nome:";
            // 
            // btnAcronym
            // 
            btnAcronym.AutoSize = true;
            btnAcronym.Location = new Point(433, 142);
            btnAcronym.Name = "btnAcronym";
            btnAcronym.Size = new Size(35, 15);
            btnAcronym.TabIndex = 0;
            btnAcronym.Text = "Sigla:";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(956, 100);
            panel5.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbDesc);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(445, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 100);
            panel2.TabIndex = 5;
            // 
            // cbDesc
            // 
            cbDesc.AutoSize = true;
            cbDesc.Location = new Point(15, 78);
            cbDesc.Name = "cbDesc";
            cbDesc.Size = new Size(89, 19);
            cbDesc.TabIndex = 7;
            cbDesc.Text = "Descresente";
            cbDesc.UseVisualStyleBackColor = true;
            cbDesc.CheckedChanged += cbDesc_CheckedChanged;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.Lupa32X32;
            btnSearch.ImageAlign = ContentAlignment.TopLeft;
            btnSearch.Location = new Point(224, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 45);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Pesquisar";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(192, 23);
            txtSearch.TabIndex = 0;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSkip);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTake);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEnd);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnPrimary);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 100);
            panel1.TabIndex = 0;
            // 
            // txtSkip
            // 
            txtSkip.Location = new Point(254, 68);
            txtSkip.Name = "txtSkip";
            txtSkip.Size = new Size(28, 23);
            txtSkip.TabIndex = 9;
            txtSkip.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 71);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Página";
            // 
            // txtTake
            // 
            txtTake.Location = new Point(154, 68);
            txtTake.Name = "txtTake";
            txtTake.Size = new Size(30, 23);
            txtTake.TabIndex = 7;
            txtTake.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 71);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 6;
            label1.Text = "Registros por Página";
            // 
            // btnEnd
            // 
            btnEnd.Image = Properties.Resources.SetaUltima32X32;
            btnEnd.ImageAlign = ContentAlignment.MiddleRight;
            btnEnd.Location = new Point(337, 12);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(103, 45);
            btnEnd.TabIndex = 4;
            btnEnd.Text = "Ultima";
            btnEnd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnNext
            // 
            btnNext.Image = Properties.Resources.Setaproxima32X32;
            btnNext.ImageAlign = ContentAlignment.TopRight;
            btnNext.Location = new Point(230, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 45);
            btnNext.TabIndex = 3;
            btnNext.Text = "Próxima";
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Image = Properties.Resources.SetaAnterior32X32;
            btnPrevious.ImageAlign = ContentAlignment.TopLeft;
            btnPrevious.Location = new Point(123, 12);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(103, 45);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Anterior";
            btnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnPrimary
            // 
            btnPrimary.Image = Properties.Resources.SetaPrimeira32X32;
            btnPrimary.ImageAlign = ContentAlignment.TopLeft;
            btnPrimary.Location = new Point(19, 12);
            btnPrimary.Name = "btnPrimary";
            btnPrimary.Size = new Size(103, 45);
            btnPrimary.TabIndex = 1;
            btnPrimary.Text = "Primeiro";
            btnPrimary.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrimary.UseVisualStyleBackColor = true;
            btnPrimary.Click += btnPrimary_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(797, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 100);
            panel4.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.Sair32X321;
            btnExit.ImageAlign = ContentAlignment.TopLeft;
            btnExit.Location = new Point(66, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Sair";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 388);
            panel3.Name = "panel3";
            panel3.Size = new Size(956, 62);
            panel3.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCancel);
            panel7.Controls.Add(btnSave);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(704, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(252, 62);
            panel7.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.Cancelar32X32;
            btnCancel.ImageAlign = ContentAlignment.TopLeft;
            btnCancel.Location = new Point(112, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 45);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Calcelar";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Salvar32X32;
            btnSave.ImageAlign = ContentAlignment.TopLeft;
            btnSave.Location = new Point(3, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "Salvar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDelete);
            panel6.Controls.Add(btnUpdate);
            panel6.Controls.Add(btnNew);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(365, 62);
            panel6.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.Excluir32X32;
            btnDelete.ImageAlign = ContentAlignment.TopLeft;
            btnDelete.Location = new Point(244, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 45);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Excluir";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Editar32X32;
            btnUpdate.ImageAlign = ContentAlignment.TopLeft;
            btnUpdate.Location = new Point(135, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 45);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Alterar";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources.Novo32X32;
            btnNew.ImageAlign = ContentAlignment.TopLeft;
            btnNew.Location = new Point(26, 6);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(103, 45);
            btnNew.TabIndex = 2;
            btnNew.Text = "Novo";
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frmPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(TabControl1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "frmPersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPersonal";
            Load += frmPersonal_Load;
            KeyDown += frmPersonal_KeyDown;
            TabControl1.ResumeLayout(false);
            tpRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPersona).EndInit();
            tpDatails.ResumeLayout(false);
            tpDatails.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl1;
        private TabPage tpRegistration;
        private DataGridView dgPersona;
        private TabPage tpDatails;
        private TextBox txtId;
        private Label lblId;
        private ComboBox cbState;
        private TextBox txtName;
        private Label lblName;
        private Label btnAcronym;
        private Panel panel5;
        private Panel panel2;
        private CheckBox cbDesc;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel1;
        private TextBox txtSkip;
        private Label label2;
        private TextBox txtTake;
        private Label label1;
        private Button btnEnd;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnPrimary;
        private Panel panel4;
        private Button btnExit;
        private Panel panel3;
        private Panel panel7;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel6;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private Label label3;
        private TextBox txtEmail;
        private MaskedTextBox mtbNumberPhone;
        private Label label4;
        private Label label7;
        private ComboBox cbGender;
        private Label label6;
        private MaskedTextBox mtbWage;
        private Label label5;
        private MaskedTextBox mtbBirthDate;
        private Label label8;
        private ComboBox cbCity;
    }
}