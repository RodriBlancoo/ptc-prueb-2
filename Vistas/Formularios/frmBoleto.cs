using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmBoleto : Form
        
    {
        public frmBoleto()
        {
            InitializeComponent();

            dgvResultados.Columns.Add("Nombre", "Nombre");
            dgvResultados.Columns.Add("Apellido", "Apellido");
            dgvResultados.Columns.Add("Fecha", "Fecha");
            dgvResultados.Columns.Add("Destino", "Destino");
            dgvResultados.Columns.Add("Peso", "Peso");
            dgvResultados.Columns.Add("SobrecargoPorPeso", "SobrecargoPorPeso");
            dgvResultados.Columns.Add("FechaHoraSalida", "FechaHoraSalida");
            dgvResultados.Columns.Add("FechaHoraLlegada", "FechaHoraLlegada");
            dgvResultados.Columns.Add("NumeroAvion", "NumeroAvion");
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.AllowUserToAddRows = false;

        }

        private void Mostrar()
        {
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = Modelos.Entidades.Boletos.Boleto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text)|| string.IsNullOrWhiteSpace(txtApellido.Text)){
                MessageBox.Show("Porvaor Completar los campos obligatorios (Nombre,Apellido y pasaporte)", 
                    "campos requeridos",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
                    
            
            
            }

            if (!decimal.TryParse(txtPesosKG.Text, out decimal pesoEquipaje)) {
                MessageBox.Show("El peso del equipaje debe ser un valor numerico","Error en los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            
            
            }

            dgvResultados.Rows.Add(
                
               txtNombre.Text,
               txtApellido.Text,
               dtFechaSalida.Value.ToShortDateString(),
               cbDestino.Text,
               dtpFechadeBoleto. Value.ToShortDateString(),
               txtAsiento.Text,
               txtPrecioTotal.Text,
               pesoEquipaje.ToString(),
               txtPesosKG.Text,
               dtpFechaLlegada.Value.ToShortDateString(),
               txtnumAvion.Text
           );
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtAsiento.Clear();
            txtPrecioTotal.Clear();
            txtPesosKG.Clear();
            txtSobreCargoPeso.Clear();
            txtnumAvion.Clear();
            dtFechaSalida.Value = DateTime.Now;
            dtpFechadeBoleto.Value = DateTime.Now;
            dtpFechaLlegada.Value = DateTime.Now;
            txtNombre.Focus();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBoleto_Load(object sender, EventArgs e)
        {

        }
    }
    
    
}
