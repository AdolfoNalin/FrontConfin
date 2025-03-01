namespace FrontConfin.View
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            arquivosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem = new ToolStripMenuItem();
            lançamentoToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblUser = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivosToolStripMenuItem, cadastroToolStripMenuItem, lançamentoToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(736, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            arquivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            arquivosToolStripMenuItem.Size = new Size(66, 20);
            arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.Sair32X321;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estadoToolStripMenuItem, cidadeToolStripMenuItem, pessoaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Image = Properties.Resources.Estado32X32;
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(180, 22);
            estadoToolStripMenuItem.Text = "Estado";
            estadoToolStripMenuItem.Click += estadoToolStripMenuItem_Click;
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Image = Properties.Resources.Cidade32X32;
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // pessoaToolStripMenuItem
            // 
            pessoaToolStripMenuItem.Image = Properties.Resources.Pessoa32X32;
            pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            pessoaToolStripMenuItem.Size = new Size(180, 22);
            pessoaToolStripMenuItem.Text = "Pessoa";
            pessoaToolStripMenuItem.Click += pessoaToolStripMenuItem_Click;
            // 
            // lançamentoToolStripMenuItem
            // 
            lançamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contaToolStripMenuItem });
            lançamentoToolStripMenuItem.Name = "lançamentoToolStripMenuItem";
            lançamentoToolStripMenuItem.Size = new Size(85, 20);
            lançamentoToolStripMenuItem.Text = "Lançamento";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Image = Properties.Resources.Conta32X32;
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(106, 22);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Image = Properties.Resources.Usuario32X32;
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(114, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 426);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Financeiro;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUser);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 47);
            panel2.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 12);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuário:";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(736, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivosToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem lançamentoToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        public Label lblUser;
    }
}