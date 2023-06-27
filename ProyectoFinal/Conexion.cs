using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ProyectoFinal
{
    internal class Conexion
    {
        private string connectionString;
        private SqlConnection connection;

        public Conexion()
        {
            // Configura la cadena de conexión a tu base de datos
            connectionString = "Data Source=localhost;Initial Catalog=Restaurante;User ID=sa;Password=Mdav@4000;Encrypt=false;";
            connection = new SqlConnection(connectionString);
        }

        public void AbrirConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return connection;
        }
    }
}
