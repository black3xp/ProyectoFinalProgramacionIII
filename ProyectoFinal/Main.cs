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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesas mesas = new frmMesas();
            mesas.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuProductos menuProductos = new frmMenuProductos();
            menuProductos.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pedidos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
        }
    }
}
