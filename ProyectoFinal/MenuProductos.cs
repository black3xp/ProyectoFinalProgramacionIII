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
    public partial class frmMenuProductos : Form
    {
        public frmMenuProductos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string idPlato = txtIdPlato.Text;
            var menus = new MenusPlatos();

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(resultado == DialogResult.Yes)
            {
                menus.Eliminar(idPlato);
                MessageBox.Show("Se elimino el elemento");
                menus.ObtenerLista(dgvMenusPlatos);
            }
            else
            {
                MessageBox.Show("No se elmino el elemento");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmNuevoPedido pedido = new frmNuevoPedido();
            foreach(DataGridViewRow fila in dgvMenusPlatos.Rows)
            {
                var item = new PedidosItems();

                if (fila.Selected)
                {
                    item.MenuPlatoId = fila.Cells["Id"].Value.ToString();
                    item.Cantidad = 1.ToString();
                    item.Descripcion = fila.Cells["NombrePlato"].Value.ToString();
                    item.Precio = fila.Cells["Precio"].Value.ToString();
                    pedido.listaProductosMenu.Add(item);
                }
            }
            Hide();
            pedido.ShowDialog();
        }

        private void frmMenuProductos_Load(object sender, EventArgs e)
        {
            if (Globals.IsPedidoEdit)
            {
                btnSeleccionar.Visible = true;
            }

            MenusPlatos menus = new MenusPlatos();
            menus.ObtenerLista(dgvMenusPlatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdPlato.Text != "")
            {
                MenusPlatos plato = new MenusPlatos();
                plato.Actualizar(txtIdPlato.Text, txtNombrePlato.Text, txtDescripcion.Text, txtIngredientes.Text, cbxRestricciones.Text, float.Parse(txtPrecio.Text), cbxDisponibilidad.Text, cbxCategoria.Text);
                MessageBox.Show("Se actualizo el menu");
                plato.ObtenerLista(dgvMenusPlatos);

                txtNombrePlato.Clear();
                txtDescripcion.Clear();
                txtIngredientes.Clear();
                txtPrecio.Clear();
                txtIdPlato.Clear();
            }
            else
            {
                MenusPlatos plato = new MenusPlatos();
                plato.Crear(txtNombrePlato.Text, txtDescripcion.Text, txtIngredientes.Text, cbxRestricciones.Text, float.Parse(txtPrecio.Text), cbxDisponibilidad.Text, cbxCategoria.Text);
                plato.ObtenerLista(dgvMenusPlatos);

                txtNombrePlato.Clear();
                txtDescripcion.Clear();
                txtIngredientes.Clear();
                txtPrecio.Clear();
                txtIdPlato.Clear();
            }
        }

        private void dgvMenusPlatos_Click(object sender, EventArgs e)
        {
            string idPlato = dgvMenusPlatos.CurrentRow.Cells["Id"].Value.ToString();
            txtIdPlato.Text = idPlato;
            btnEliminar.Enabled = true;
            btnSeleccionar.Enabled = true;
        }

        private void dgvMenusPlatos_DoubleClick(object sender, EventArgs e)
        {
            txtIdPlato.Text = dgvMenusPlatos.CurrentRow.Cells["Id"].Value.ToString();
            txtDescripcion.Text = dgvMenusPlatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            txtIngredientes.Text = dgvMenusPlatos.CurrentRow.Cells["Ingredientes"].Value.ToString();
            txtNombrePlato.Text = dgvMenusPlatos.CurrentRow.Cells["NombrePlato"].Value.ToString();
            txtPrecio.Text = dgvMenusPlatos.CurrentRow.Cells["Precio"].Value.ToString();
            cbxCategoria.Text = dgvMenusPlatos.CurrentRow.Cells["Categoria"].Value.ToString();
            cbxDisponibilidad.Text = dgvMenusPlatos.CurrentRow.Cells["Disponibilidad"].Value.ToString();
            cbxRestricciones.Text = dgvMenusPlatos.CurrentRow.Cells["RestriccionesDieteticas"].Value.ToString();

            btnSeleccionar.Enabled = true;
        }
    }
}
