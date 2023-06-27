using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Mesa
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public Mesa(string id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
        public Mesa()
        {

        }
        public void ObtenerLista(DataGridView dgv)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "exec SelectMesas";
                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
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

        public bool Crear(string descripcion, string ubicacion, int numeroMesa, int capacidad, string estado)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC InsertMesa @Descripcion = @Descripcion, @Ubicacion = @Ubicacion, @NumeroMesa = @NumeroMesa, @Capacidad = @Capacidad, @Estado = @Estado";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Ubicacion", ubicacion);
                    command.Parameters.AddWithValue("@NumeroMesa", numeroMesa);
                    command.Parameters.AddWithValue("@Capacidad", capacidad);
                    command.Parameters.AddWithValue("@Estado", estado);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    MessageBox.Show("Se ha registrado la mesa");
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
        public bool Actualizar(int mesaId, string descripcion, string ubicacion, int numeroMesa, int capacidad, string estado)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC UpdateMesa @MesaId = @MesaId, @Descripcion = @Descripcion, @Ubicacion = @Ubicacion, @NumeroMesa = @NumeroMesa, @Capacidad = @Capacidad, @Estado = @Estado";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@MesaId", mesaId);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Ubicacion", ubicacion);
                    command.Parameters.AddWithValue("@NumeroMesa", numeroMesa);
                    command.Parameters.AddWithValue("@Capacidad", capacidad);
                    command.Parameters.AddWithValue("@Estado", estado);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    MessageBox.Show("Se ha registrado la mesa");
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
                    string query = "exec DeleteMesa @MesaId";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@MesaId", id);

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
