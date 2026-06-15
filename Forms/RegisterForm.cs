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
            //cmbRole.DataSource = roles;
            //cmbRole.DisplayMember = "Name";
            //cmbRole.ValueMember = "Id";
        }

    }
}
