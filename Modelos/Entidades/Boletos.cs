using Modelos.Conexion;
 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Boletos
    {
        private int idBoleto;
        private string Nombre;
        private string Apellido;
        private DateTime Fecha;
        private string Destino;
        private double Peso;
        private double SobrecargoPeso;
        private string Asiento;
        private DateTime FechaHoraLlegada;
        private DateTime FechaHoraSalida;
        private string NumeroAvion;

        public int IdBoleto { get => idBoleto; set => idBoleto = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string Destino1 { get => Destino; set => Destino = value; }
        public double Peso1 { get => Peso; set => Peso = value; }
        public double SobrecargoPeso1 { get => SobrecargoPeso; set => SobrecargoPeso = value; }
        public string Asiento1 { get => Asiento; set => Asiento = value; }
        public DateTime FechaHoraLlegada1 { get => FechaHoraLlegada; set => FechaHoraLlegada = value; }
        public DateTime FechaHoraSalida1 { get => FechaHoraSalida; set => FechaHoraSalida = value; }
        public string NumeroAvion1 { get => NumeroAvion; set => NumeroAvion = value; }

        public static DataTable Boleto()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
              string cadena = "select *from Boleto";
                SqlDataAdapter add = new SqlDataAdapter(cadena, conexion);
                DataTable tablaCargar = new DataTable();
                add.Fill(tablaCargar);
                return tablaCargar;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "tonto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public bool insertarZapatos()

        {
            try
            {

                SqlConnection conexion = Conexion.Conectar();

                string consultaQueryInsert = "INSERT INTO Boleto (idBoleto,Nombre, Apellido, Fecha, Destino, Peso, SobrecargoPorPeso, Asiento, FechaHoraSalida, FechaHoraLlegada, NumeroAvion) VALUES " +
                    "(@idBoleto,@Nombre,@Apellido, @Fecha, @Destino , @Peso, @SobrecargoPorPeso, @Asiento, @FechaHoraSalida, @FechaHoraLlegada, @NumeroAvion)";

                SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);

                insertar.Parameters.AddWithValue("@idBoleto", idBoleto);

                insertar.Parameters.AddWithValue("@Nombre", Nombre);

                insertar.Parameters.AddWithValue("@Apellido", Apellido);

                insertar.Parameters.AddWithValue("@Fecha", Fecha);

                insertar.Parameters.AddWithValue("@Destino", Destino);

                insertar.Parameters.AddWithValue("@Peso", Peso);

                insertar.Parameters.AddWithValue("@SobrecargoPorPeso", SobrecargoPeso);

                insertar.Parameters.AddWithValue("@Asiento", Asiento);

                insertar.Parameters.AddWithValue("@FechaHoraSalida", FechaHoraSalida);

                insertar.Parameters.AddWithValue("@FechaHoraLlegada", FechaHoraLlegada);

                insertar.Parameters.AddWithValue("@NumeroAvion", NumeroAvion);


                insertar.ExecuteNonQuery();

                return true;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Verifica si la consulta es correcta" + ex, "error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

        }
        public bool eliminarBoleto(int id)

        {
            try
            {

                SqlConnection conectar = Conexion.Conectar();

                string consultaDelete = "DELETE FROM Boleto WHERE id = @id";

                SqlCommand delete = new SqlCommand(consultaDelete, conectar);

                delete.Parameters.AddWithValue("@Id", id);

                delete.ExecuteNonQuery();

                return true;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error al eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

        }
        public bool actualizarBoleto()

        {
            try
            {

                SqlConnection conectar = Conexion.Conectar();

                string consultaUpdate = "UPDATE Boleto SET idBoleto = @idCategoria, nombre =@nombre, precio = @precio, fechaCreacion = @fechaCreacion WHERE Id = @Id";

                SqlCommand update = new SqlCommand(consultaUpdate, conectar);

                update.Parameters.AddWithValue("@idBoleto", idBoleto);

                update.Parameters.AddWithValue("@Nombre", Nombre);

                update.Parameters.AddWithValue("@Apellido", Apellido);

                update.Parameters.AddWithValue("@Fecha", Fecha);

                update.Parameters.AddWithValue("@Destino", Destino);

                update.Parameters.AddWithValue("@Peso", Peso);

                update.Parameters.AddWithValue("@SobrecargoPorPeso", SobrecargoPeso);

                update.Parameters.AddWithValue("@Asiento", Asiento);

                update.Parameters.AddWithValue("@FechaHoraSalida", FechaHoraSalida);

                update.Parameters.AddWithValue("@FechaHoraLlegada", FechaHoraLlegada);

                update.Parameters.AddWithValue("@NumeroAvion", NumeroAvion);


                update.ExecuteNonQuery();

                return true;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error al actualizar el registro" + ex, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

        }
        public static DataTable buscarZapatos(string termino)
        {
            SqlConnection conexion = Conexion.Conectar();
            string comando =
                $"SELECT Boletos.idBoleto, Nombre .Apellido, Categorias.Nombre from Zapatos inner join Categorias on Categorias.Id = Zapatos.CategoriaId WHERE zapatos.nombre like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }


    }
    }
}
