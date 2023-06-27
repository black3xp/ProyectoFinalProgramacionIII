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
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            Close();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            mesa.ObtenerLista(dgvMesas);
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtIdMesa.Text != "")
            {
                Mesa mesa = new Mesa();
                mesa.Actualizar(Int32.Parse(txtIdMesa.Text),txtDescripcion.Text, txtUbicacion.Text, Int32.Parse(txtNumeroMesa.Text), Int32.Parse(txtCapacidad.Text), cbxEstado.Text);
                mesa.ObtenerLista(dgvMesas);

                txtDescripcion.Clear();
                txtCapacidad.Clear();
                txtIdMesa.Clear();
                txtNumeroMesa.Clear();
                txtUbicacion.Clear();
            }
            else
            {
                Mesa mesa = new Mesa();
                mesa.Crear(txtDescripcion.Text, txtUbicacion.Text, Int32.Parse(txtNumeroMesa.Text), Int32.Parse(txtCapacidad.Text), cbxEstado.Text);
                mesa.ObtenerLista(dgvMesas);

                txtDescripcion.Clear();
                txtCapacidad.Clear();
                txtIdMesa.Clear();
                txtNumeroMesa.Clear();
                txtUbicacion.Clear();
            }
        }

        private void dgvMesas_Click(object sender, EventArgs e)
        {
            string idMesa = dgvMesas.CurrentRow.Cells["Id"].Value.ToString();
            txtIdMesa.Text = idMesa;
            btnEliminar.Enabled = true;
        }

        private void dgvMesas_DoubleClick(object sender, EventArgs e)
        {
            string idMesa = dgvMesas.CurrentRow.Cells["Id"].Value.ToString();
            txtIdMesa.Text = idMesa;
            btnEliminar.Enabled = false;

            txtDescripcion.Text = dgvMesas.CurrentRow.Cells["Descripcion"].Value.ToString();
            txtCapacidad.Text = dgvMesas.CurrentRow.Cells["Capacidad"].Value.ToString();
            txtNumeroMesa.Text = dgvMesas.CurrentRow.Cells["NumeroMesa"].Value.ToString();
            txtUbicacion.Text = dgvMesas.CurrentRow.Cells["Ubicacion"].Value.ToString();
            cbxEstado.Text = dgvMesas.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Mesa mesa = new Mesa();
                mesa.Eliminar(txtIdMesa.Text);
                mesa.ObtenerLista(dgvMesas);
                MessageBox.Show("Mesa Eliminada");
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se elminio el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
