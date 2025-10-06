using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Login : Form
    {
        UsuarioDao users = new UsuarioDao();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loguear();
        }
        private void Loguear()
        {
            if (users.Validar(tbUsuario.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Loguear();
            }
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            tbPassword.Focus();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                tbPassword.PasswordChar = '\0';
                chkShowPass.Text = "Ocultar";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                chkShowPass.Text = "Mostrar";
            }
        }
    }
}
