namespace LoginSystem007.Forms
{
    partial class MainForm
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
            lblWelcome = new Label();
            btnAdminPanel = new Button();
            btnLogout = new Button();
            btnExcluir = new Button();
            dgvPainel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPainel).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 24);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Location = new Point(12, 53);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(75, 23);
            btnAdminPanel.TabIndex = 1;
            btnAdminPanel.Text = "Admin ";
            btnAdminPanel.UseVisualStyleBackColor = true;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(231, 197);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(113, 53);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvPainel
            // 
            dgvPainel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPainel.Location = new Point(12, 82);
            dgvPainel.Name = "dgvPainel";
            dgvPainel.Size = new Size(294, 109);
            dgvPainel.TabIndex = 4;
            dgvPainel.CellContentClick += dgvPainel_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 226);
            Controls.Add(dgvPainel);
            Controls.Add(btnExcluir);
            Controls.Add(btnLogout);
            Controls.Add(btnAdminPanel);
            Controls.Add(lblWelcome);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPainel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAdminPanel;
        private Button btnLogout;
        private Button btnExcluir;
        private DataGridView dgvPainel;
    }
}