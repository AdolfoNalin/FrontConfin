namespace FrontConfin.View
{
    partial class frmAccount
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
            dgAccount = new DataGridView();
            tpDatails = new TabPage();
            label7 = new Label();
            cbPersona = new ComboBox();
            label6 = new Label();
            cbSituation = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            mtbPaymentDate = new MaskedTextBox();
            mtbDateDue = new MaskedTextBox();
            txtId = new TextBox();
            lblId = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
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
            mtbValue = new MaskedTextBox();
            TabControl1.SuspendLayout();
            tpRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAccount).BeginInit();
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
            TabControl1.Size = new Size(957, 288);
            TabControl1.TabIndex = 10;
            // 
            // tpRegistration
            // 
            tpRegistration.Controls.Add(dgAccount);
            tpRegistration.Location = new Point(27, 4);
            tpRegistration.Name = "tpRegistration";
            tpRegistration.Padding = new Padding(3);
            tpRegistration.Size = new Size(926, 280);
            tpRegistration.TabIndex = 0;
            tpRegistration.Text = "Registros";
            tpRegistration.UseVisualStyleBackColor = true;
            // 
            // dgAccount
            // 
            dgAccount.BackgroundColor = SystemColors.ActiveCaption;
            dgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAccount.Dock = DockStyle.Fill;
            dgAccount.Location = new Point(3, 3);
            dgAccount.Name = "dgAccount";
            dgAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAccount.Size = new Size(920, 274);
            dgAccount.TabIndex = 0;
            dgAccount.SelectionChanged += dgAccount_SelectionChanged;
            // 
            // tpDatails
            // 
            tpDatails.Controls.Add(label7);
            tpDatails.Controls.Add(cbPersona);
            tpDatails.Controls.Add(label6);
            tpDatails.Controls.Add(cbSituation);
            tpDatails.Controls.Add(label5);
            tpDatails.Controls.Add(mtbValue);
            tpDatails.Controls.Add(label4);
            tpDatails.Controls.Add(label3);
            tpDatails.Controls.Add(mtbPaymentDate);
            tpDatails.Controls.Add(mtbDateDue);
            tpDatails.Controls.Add(txtId);
            tpDatails.Controls.Add(lblId);
            tpDatails.Controls.Add(txtDescription);
            tpDatails.Controls.Add(lblDescription);
            tpDatails.Location = new Point(27, 4);
            tpDatails.Name = "tpDatails";
            tpDatails.Padding = new Padding(3);
            tpDatails.Size = new Size(926, 280);
            tpDatails.TabIndex = 1;
            tpDatails.Text = "Detalhes";
            tpDatails.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 145);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 16;
            label7.Text = "Pessoa:";
            // 
            // cbPersona
            // 
            cbPersona.FormattingEnabled = true;
            cbPersona.Location = new Point(27, 163);
            cbPersona.Name = "cbPersona";
            cbPersona.Size = new Size(284, 23);
            cbPersona.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 145);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 14;
            label6.Text = "Situação:";
            // 
            // cbSituation
            // 
            cbSituation.FormattingEnabled = true;
            cbSituation.Items.AddRange(new object[] { "close", "open" });
            cbSituation.Location = new Point(557, 163);
            cbSituation.Name = "cbSituation";
            cbSituation.Size = new Size(68, 23);
            cbSituation.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(560, 87);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 145);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 10;
            label4.Text = "Data de pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 87);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 9;
            label3.Text = "Data de validade:";
            // 
            // mtbPaymentDate
            // 
            mtbPaymentDate.Location = new Point(379, 163);
            mtbPaymentDate.Mask = "00/00/0000";
            mtbPaymentDate.Name = "mtbPaymentDate";
            mtbPaymentDate.Size = new Size(58, 23);
            mtbPaymentDate.TabIndex = 8;
            mtbPaymentDate.ValidatingType = typeof(DateTime);
            // 
            // mtbDateDue
            // 
            mtbDateDue.Location = new Point(376, 105);
            mtbDateDue.Mask = "00/00/0000";
            mtbDateDue.Name = "mtbDateDue";
            mtbDateDue.Size = new Size(61, 23);
            mtbDateDue.TabIndex = 7;
            mtbDateDue.ValidatingType = typeof(DateTime);
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
            // txtDescription
            // 
            txtDescription.CharacterCasing = CharacterCasing.Upper;
            txtDescription.Location = new Point(30, 101);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(288, 23);
            txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(36, 87);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(61, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Descrição:";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(957, 100);
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
            panel2.Size = new Size(353, 100);
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
            panel4.Location = new Point(798, 0);
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
            panel3.Size = new Size(957, 62);
            panel3.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCancel);
            panel7.Controls.Add(btnSave);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(705, 0);
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
            // mtbValue
            // 
            mtbValue.Location = new Point(560, 105);
            mtbValue.Name = "mtbValue";
            mtbValue.Size = new Size(85, 23);
            mtbValue.TabIndex = 11;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(TabControl1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAccount";
            Load += frmAccount_Load;
            TabControl1.ResumeLayout(false);
            tpRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgAccount).EndInit();
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
        private DataGridView dgAccount;
        private TabPage tpDatails;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtDescription;
        private Label lblDescription;
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
        private Label label4;
        private Label label3;
        private MaskedTextBox mtbPaymentDate;
        private MaskedTextBox mtbDateDue;
        private Label label5;
        private Label label6;
        private ComboBox cbSituation;
        private Label label7;
        private ComboBox cbPersona;
        private MaskedTextBox mtbValue;
    }
}