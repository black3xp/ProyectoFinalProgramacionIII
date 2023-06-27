using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class MenusPlatos
    {
        public void ObtenerLista(DataGridView dgv)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "exec SelectMenusPlatos";
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

        public bool Crear(string nombrePlato, string descripcion, string ingredientes, string restriccion, float precio, string disponibilidad, string categoria)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC InsertMenuPlato @NombrePlato, @Descripcion, @Ingredientes, @RestriccionesDieteticas, @Precio, @Disponibilidad, @Categoria";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@NombrePlato", nombrePlato);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Ingredientes", ingredientes);
                    command.Parameters.AddWithValue("@RestriccionesDieteticas", restriccion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                    command.Parameters.AddWithValue("@Categoria", categoria);

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
        public bool Actualizar(string idPlato, string nombrePlato, string descripcion, string ingredientes, string restriccion, float precio, string disponibilidad, string categoria)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "EXEC UpdateMenuPlato @MenuPlatoId, @NombrePlato, @Descripcion, @Ingredientes, @RestriccionesDieteticas, @Precio, @Disponibilidad, @Categoria";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@MenuPlatoId", idPlato);
                    command.Parameters.AddWithValue("@NombrePlato", nombrePlato);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Ingredientes", ingredientes);
                    command.Parameters.AddWithValue("@RestriccionesDieteticas", restriccion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                    command.Parameters.AddWithValue("@Categoria", categoria);

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
                    string query = "exec DeleteMenuPlato @MenuPlatoId";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@MenuPlatoId", id);

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
