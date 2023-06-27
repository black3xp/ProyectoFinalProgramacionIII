using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    internal class Usuario
    {
        public static bool Login(string username, string password)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            try
            {

                using (SqlConnection sqlConnection = conexion.ObtenerConexion())
                {
                    //string query = "exec LoginUsuario @Username, @Password";
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int result = (int)command.ExecuteScalar();

                    // Verificar si las credenciales son válidas
                    if (result > 0)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void ObtenerLista(DataGridView dgv)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "exec SelectUsuarios";
                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al llenar el DataGridView: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public bool CrearUsuario(string nombreCompleto, string password, string usuario, string sexo, string email, string telefono)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC spCrearUsuario @NombreCompleto = @NombreCompleto, @Password = @Password, @Usuario = @Usuario, @Sexo = @Sexo, @Email = @Email, @Telefono = @Telefono";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Eliminar(string id)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "exec DeleteUsuario @IdUsuario";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@IdUsuario", id);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al llenar el DataGridView: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }
    }
}
