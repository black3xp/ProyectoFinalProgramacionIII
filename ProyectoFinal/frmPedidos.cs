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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.IsPedidoForm = true;

            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoPedido frmNuevoPedido = new frmNuevoPedido();
            Hide();
            frmNuevoPedido.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            Pedidos.ObtenerLista(dgvPedidos, null);
        }
    }
}
