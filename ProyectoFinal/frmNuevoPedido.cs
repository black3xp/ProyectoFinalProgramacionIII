using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmNuevoPedido : Form
    {
        public List<PedidosItems> listaProductosMenu = new List<PedidosItems>();
        public frmNuevoPedido()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globals.IsPedidoEdit = true;

            frmClientes frmClientes = new frmClientes();
            Hide();
            frmClientes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globals.IsPedidoEdit = true;
            frmMenuProductos frmMenuProductos = new frmMenuProductos();
            Hide();
            frmMenuProductos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.NombreCliente = "";
            Globals.IdClienteSelect = "";
            Close();
        }

        private void frmNuevoPedido_Load(object sender, EventArgs e)
        {
            //desactivar(btnAgregarMesa);


            if (Globals.IsPedidoEdit && Globals.NombreCliente != "")
            {
                txtCliente.Text = Globals.NombreCliente;
            }
            foreach(var item in listaProductosMenu)
            {
                dgvNuevoPedido.Rows.Add(item.MenuPlatoId, item.Cantidad, item.Descripcion, item.Precio);
            }

            string connectionString = "Data Source=localhost;Initial Catalog=Restaurante;User ID=sa;Password=Mdav@4000;Encrypt=false;";
            string query = "SELECT Id, Descripcion FROM Mesas"; // Ajusta la consulta según las columnas que deseas obtener

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Crea una lista para almacenar los datos de las mesas
                List<Mesa> mesas = new List<Mesa>();

                while (reader.Read())
                {
                    // Lee los valores de cada registro y crea una instancia de la clase Mesa
                    int id = reader.GetInt32(0); // Ajusta el índice según la posición de la columna Id en la consulta
                    string descripcion = reader.GetString(1); // Ajusta el índice según la posición de la columna Descripcion en la consulta

                    Mesa mesa = new Mesa(id.ToString(), descripcion);
                    mesas.Add(mesa);
                }

                reader.Close();

                // Asigna la lista de mesas como origen de datos del ComboBox
                cbxMesa.DataSource = mesas;
                cbxMesa.DisplayMember = "Id"; // Ajusta el nombre de la propiedad que deseas mostrar en el ComboBox
                cbxMesa.ValueMember = "Descripcion"; // Ajusta el nombre de la propiedad que deseas utilizar como valor seleccionado
            }
        }

        private void frmNuevoPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.NombreCliente = "";
            Globals.IdClienteSelect = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("No tiene un cliente seleccionado", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(listaProductosMenu.Count <= 0)
            {
                MessageBox.Show("No ha seleccionado ningun plato del menu", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtCliente.Text == "" || txtDetalles.Text == "" || txtDireccion.Text == "" || cbxEstado.Text == "" || cbxMesa.Text == "")
            {
                MessageBox.Show("Todos los datos son obligatorios", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtIdPedido.Text != "")
            {

            }
            else
            {
                var pedido = new Pedidos();
                pedido.ClienteId = int.Parse(Globals.IdClienteSelect);
                pedido.Detalles = txtDetalles.Text;
                pedido.Direccion = txtDireccion.Text;
                pedido.MesaId = cbxMesa.Text;
                pedido.EstadoPedido = cbxEstado.Text;

                pedido.Crear(listaProductosMenu);
                
                var frmPedidos = new frmPedidos();
                Close();
                frmPedidos.Show();
            }
        }


        //private Button desactivar(Button boton)
        //{
        //    if(boton.Tag.ToString()== "agregar")
        //    {
        //        boton.Visible = true;
        //    }
        //    else
        //    {
        //        boton.Visible = false;
        //    }

        //    return boton;
        //}




        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            var mes = new frmMesas();
            mes.ShowDialog();
            
            string connectionString = "Data Source=localhost;Initial Catalog=Restaurante;User ID=sa;Password=Mdav@4000;Encrypt=false;";
            string query = "SELECT Id, Descripcion FROM Mesas"; // Ajusta la consulta según las columnas que deseas obtener

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Crea una lista para almacenar los datos de las mesas
                List<Mesa> mesas = new List<Mesa>();

                while (reader.Read())
                {
                    // Lee los valores de cada registro y crea una instancia de la clase Mesa
                    int id = reader.GetInt32(0); // Ajusta el índice según la posición de la columna Id en la consulta
                    string descripcion = reader.GetString(1); // Ajusta el índice según la posición de la columna Descripcion en la consulta

                    Mesa mesa = new Mesa(id.ToString(), descripcion);
                    mesas.Add(mesa);
                }

                reader.Close();

                // Asigna la lista de mesas como origen de datos del ComboBox
                cbxMesa.DataSource = mesas;
                cbxMesa.DisplayMember = "Id"; // Ajusta el nombre de la propiedad que deseas mostrar en el ComboBox
                cbxMesa.ValueMember = "Descripcion"; // Ajusta el nombre de la propiedad que deseas utilizar como valor seleccionado
            }

        }
    }
}
