using LoginSystem007.Models;
using Microsoft.Data.SqlClient;
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
            if (AuthService.IsInRole(Session.LoggedUser, "Admin"))
            {
                btnExcluir.Visible = true;
            }
            else
            {
                btnExcluir.Visible = false;
            }
            if (AuthService.IsInRole(Session.LoggedUser, "Admin"))
            {
                dgvPainel.Visible = true;
            }
            else
            {
                dgvPainel.Visible = false;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPainel.SelectedRows.Count > 0)
            {
                dgvPainel.Rows.Remove(dgvPainel.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        private void dgvPainel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("sua_string_de_conexao");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuarios", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgvPainel.DataSource = dt;
        }
    }
}
