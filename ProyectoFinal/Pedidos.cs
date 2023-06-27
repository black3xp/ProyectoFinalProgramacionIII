using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoFinal
{
    internal class Pedidos
    {
        public int? Id { get; set; }
        public int ClienteId { get; set; }
        public string Detalles { get; set; }
        public string Direccion { get; set; }
        public string MesaId { get; set; }
        public string EstadoPedido { get; set; }
        public List<PedidosItems> PedidosItems { get; set; }
        public Pedidos(string? Id, int ClienteId, string Detalles, string MesaId, string EstadoPedido, List<PedidosItems> pedidosItems)
        {
            if (Id != null)
            {
                this.Id = int.Parse(Id);
            }
            this.ClienteId = ClienteId;
            this.Detalles = Detalles;
            this.MesaId = MesaId;
            this.EstadoPedido = EstadoPedido;
            PedidosItems = pedidosItems;
        }
        public Pedidos()
        {

        }
        public static void ObtenerLista(DataGridView dgv, string? clienteId)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                try
                {
                    if (clienteId != null)
                    {
                        string query = "exec SelectPedidos @Nombres";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.Parameters.AddWithValue("@Nombres", clienteId);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dgv.DataSource = dataTable;
                    }
                    else
                    {
                        string query = "exec SelectPedidos";
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

        public bool Crear(List<PedidosItems> ItemsPedidos)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();
            using (SqlConnection sqlConnection = conexion.ObtenerConexion())
            {
                SqlTransaction transaction = conexion.ObtenerConexion().BeginTransaction();

                try
                {
                    // Insertar los pedidos

                        SqlCommand commandPedido = new SqlCommand("exec InsertPedido @ClienteId, @Detalles, @Direccion, @MesaId, @EstadoPedido", conexion.ObtenerConexion(), transaction);
                        commandPedido.Parameters.AddWithValue("@ClienteId", ClienteId);
                        commandPedido.Parameters.AddWithValue("@Detalles", Detalles);
                        commandPedido.Parameters.AddWithValue("@Direccion", Direccion);
                        commandPedido.Parameters.AddWithValue("@MesaId", int.Parse(MesaId));
                        commandPedido.Parameters.AddWithValue("@EstadoPedido", EstadoPedido);

                        int pedidoId = Convert.ToInt32(commandPedido.ExecuteScalar());

                        // Insertar los detalles del pedido
                        foreach (var item in ItemsPedidos)
                        {
                            SqlCommand commandDetalle = new SqlCommand("exec InsertPedidoItems @PedidoId, @MenuPlatoId, @Cantidad, @Precio", conexion.ObtenerConexion(), transaction);
                            commandDetalle.Parameters.AddWithValue("@PedidoId", pedidoId);
                            commandDetalle.Parameters.AddWithValue("@MenuPlatoId", int.Parse(item.MenuPlatoId));
                            commandDetalle.Parameters.AddWithValue("@Cantidad", int.Parse(item.Cantidad));
                            commandDetalle.Parameters.AddWithValue("@Precio", float.Parse(item.Precio));

                            commandDetalle.ExecuteNonQuery();
                        }

                    // Confirmar la transacción
                    transaction.Commit();
                    MessageBox.Show("Transacción confirmada.");
                    return true;
                }
                catch (Exception ex)
                {
                    // Deshacer la transacción en caso de error
                    transaction.Rollback();
                    MessageBox.Show("Error en la transacción: " + ex.Message);
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
                    ///command.Parameters.AddWithValue("@ClienteId", Id);
                    //command.Parameters.AddWithValue("@Nombres", Nombres);
                    //.Parameters.AddWithValue("@Apellidos", Apellidos);
                    //command.Parameters.AddWithValue("@Email", Email);
                    //command.Parameters.AddWithValue("@Telefono", Telefono);

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
