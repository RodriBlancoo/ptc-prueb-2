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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            AbrirFormularioBoletos();
        }

        private void AbrirFormularioBoletos()
        {

            pnlPrincipal.Controls.Clear();
            frmBoleto formularioBoletos = new frmBoleto();

            formularioBoletos.TopLevel = false;
            formularioBoletos.FormBorderStyle = FormBorderStyle.None;
            formularioBoletos.Dock = DockStyle.Fill;

            pnlPrincipal.Controls.Add(formularioBoletos);
            formularioBoletos.Show();







        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEmpleado();
        }

        private void AbrirFormularioEmpleado()
        {

            pnlPrincipal.Controls.Clear();
            frmEmpleado formularioEmpleados = new frmEmpleado();

            formularioEmpleados.TopLevel = false;
            formularioEmpleados.FormBorderStyle = FormBorderStyle.None;
            formularioEmpleados.Dock = DockStyle.Fill;

            pnlPrincipal.Controls.Add(formularioEmpleados);
            formularioEmpleados.Show();
        }
    }
}


    

   
  

    

