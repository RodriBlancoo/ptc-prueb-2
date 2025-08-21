using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "123";
            string claveCorrecta = "45";

            if (txtuser.Text == usuarioCorrecto && txtPass.Text == claveCorrecta)
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de login",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
