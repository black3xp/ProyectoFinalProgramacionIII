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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            
            if (Globals.IsPedidoForm || Globals.IsPedidoEdit)
            {
                btnSeleccionar.Visible = true;
            }

            Clientes.ObtenerLista(dgvClientes, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                Clientes.Eliminar(txtIdCliente.Text);
                Clientes.ObtenerLista(dgvClientes, null);
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se elminio el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.IsPedidoForm = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtIdCliente.Text != "")
            {
                var cliente = new Clientes(txtIdCliente.Text, txtNombres.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text);
                cliente.Actualizar();
                Clientes.ObtenerLista(dgvClientes, null);

            }
            else
            {
                var cliente = new Clientes(null, txtNombres.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text);
                cliente.Crear();
                MessageBox.Show("Se creo el cliente");
                Clientes.ObtenerLista(dgvClientes, null);
            }

            txtIdCliente.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            txtTelefono.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtIdCliente.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells["Email"].Value.ToString();
            txtApellidos.Text = dgvClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            txtNombres.Text = dgvClientes.CurrentRow.Cells["Nombres"].Value.ToString();
        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {
            string idCliente = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtIdCliente.Text = idCliente;
            btnEliminar.Enabled = true;
            btnSeleccionar.Enabled = true;

            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clientes.ObtenerLista(dgvClientes, txtBuscarCliente.Text);
            txtIdCliente.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmNuevoPedido pedido = new frmNuevoPedido();
            Globals.NombreCliente = dgvClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            Globals.IdClienteSelect = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
            btnSeleccionar.Enabled = false;
            Hide();
            pedido.ShowDialog();
        }
    }
}
