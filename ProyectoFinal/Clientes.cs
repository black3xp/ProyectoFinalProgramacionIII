using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Clientes
    {
        public int? Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Clientes(string? Id, string Nombres, string Apellidos, string Email, string Telefono)
        {
            if(Id != null)
            {
                this.Id = int.Parse(Id);
            }
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Email = Email;
            this.Telefono = Telefono;
        }
        public Clientes()
        {

        }
        public static void ObtenerLista(DataGridView dgv, string? busqueda)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    if (busqueda != null)
                    {
                        string query = "exec SelectClientes @Nombres";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.Parameters.AddWithValue("@Nombres", busqueda);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dgv.DataSource = dataTable;
                    }
                    else
                    {
                        string query = "exec SelectClientes";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dgv.DataSource = dataTable;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public bool Crear()
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC InsertCliente @Nombres, @Apellidos, @Email, @Telefono";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@Nombres", Nombres);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Telefono", Telefono);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    MessageBox.Show("Se ha registrado la el plato");

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
        public bool Actualizar()
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC UpdateCliente @ClienteId, @Nombres, @Apellidos, @Email, @Telefono";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@ClienteId", Id);
                    command.Parameters.AddWithValue("@Nombres", Nombres);
                    command.Parameters.AddWithValue("@Apellidos", Apellidos);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Telefono", Telefono);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    MessageBox.Show("Se ha actualizado el cliente");
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
        public static void Eliminar(string id)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "exec DeleteCliente @ClienteId";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@ClienteId", id);

                    // Ejecutar el comando DELETE
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("El registro ha sido eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el registro a eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }
    }
}
