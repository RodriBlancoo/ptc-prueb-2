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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("nombre", "nombre");
            dataGridView1.Columns.Add("apellidos", "apellidos");
            dataGridView1.Columns.Add("Fecha Contratacion", "Fecha Contratacion");
            dataGridView1.Columns.Add("Nacimiento", "Nacimiento");
            dataGridView1.Columns.Add("Departamento", "Departamento");
            dataGridView1.Columns.Add("Licencia Vuelo", "Licencia Vuelo");
            dataGridView1.Columns.Add("Salario Base", "Salario Base");
            dataGridView1.Columns.Add("Descriocion Funciones", "Descriocion Funciones");
            dataGridView1.Columns.Add("Estado Asignacion", "Estado Asignacion");
            dataGridView1.Columns.Add("Fecha de Asignacion", "Fecha de Asignacion");
            dataGridView1.Columns.Add("Fecha de Creacion de la tripulacion", "Fecha de Creacion de la tripulacion");
            dataGridView1.Columns.Add("Estado de Tripulacion", "Estado de Tripulacion");
            dataGridView1.Columns.Add("Certificaciones", "Certificaciones");
            dataGridView1.Columns.Add("Nombre de Tripulacion", "Nombre de Tripulacion");
            dataGridView1.Columns.Add("Notas de Operativas", "Notas de Operativas");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(dtContratacion.Text))
            {
                MessageBox.Show("Porvaor Completar los campos obligatorios (Nombre,Apellido y pasaporte)", "campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;




            }

            if (!decimal.TryParse(txtSalarioBAse.Text, out decimal pesoEquipaje))
            {
                MessageBox.Show("El peso del equipaje debe ser un valor numerico", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;



            }


            dataGridView1.Rows.Add(

   txtNombre.Text,
   txtApellido.Text,

   dtContratacion.Value.ToShortDateString(),
   txtDepartamento.Text,
   txtSalarioBAse.Text,


 
   txtDescripcionFunciones.Text,
   txtNombreTripulacion.Text,
   txtNotasOperativas.Text,
  txtNotasOperativas.Text,
   cbCertificacion.Text,
   cbEsatdoAsignacion.Text,
   cbEstadoTripulacion.Text,
   dtFechaAsignacion.Value.ToShortDateString(),
    dtFechaCreacion.Value.ToShortDateString()
);
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDepartamento.Clear();
            txtSalarioBAse.Clear();
            txtDescripcionFunciones.Clear();
            txtNombreTripulacion.Clear();
            txtNotasOperativas.Clear();
            dtContratacion.Value = DateTime.Now;
            dtFechaAsignacion.Value = DateTime.Now;
            dtFechaCreacion.Value = DateTime.Now;
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
