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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadRoles();
        }
        private void LoadRoles()
        {
            using var db = new AppDbContext();
            var roles = db.Roles.ToList();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string selectedRole = (cmbRole.SelectedItem as Role)?.Name;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
            string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }
            bool success = AuthService.RegisterUser(username, email, password,
           selectedRole);
            if (success)
            {
                MessageBox.Show("Usuário cadastrado com sucesso! Faça login.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou e-mail já existente.");
            }

        }
    }
}
