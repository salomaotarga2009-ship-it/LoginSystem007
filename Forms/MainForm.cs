using LoginSystem007.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginSystem007.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área administrativa (você pode listar usuários, etc.)");
            // Abrir um form de administração, etc.
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.LoggedUser = null;
            this.Close();
            Application.Restart();
            // Ou reabrir o LoginForm
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bem-vindo, {Session.LoggedUser.Username}!";
            if (AuthService.IsInRole(Session.LoggedUser, "Admin"))
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }

        }
    }
}
