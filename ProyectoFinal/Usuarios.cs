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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            if(cbxSexo.Items.Count > 0)
            {
                cbxSexo.SelectedIndex = 0;
            }

            Usuario usuario = new Usuario();
            usuario.ObtenerLista(dgvUsuarios);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtIdUsuario.Text == "")
            {
                string sexo;
                if(cbxSexo.Text == "Masculino")
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }
                
                if(txtPassword.Text != txtRepeatPassword.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }

                Usuario usuario = new Usuario();
                usuario.CrearUsuario(txtNombreCompleto.Text, txtPassword.Text, txtUsuario.Text, sexo, txtEmail.Text, txtTelefono.Text);
                usuario.ObtenerLista(dgvUsuarios);

                txtRepeatPassword.Clear();
                txtPassword.Clear();
                txtNombreCompleto.Clear();
                txtEmail.Clear();
                txtIdUsuario.Clear();
                txtTelefono.Clear();
                txtIdUsuario.Clear();
            }
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            string idUsuario = dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString();
            txtIdUsuario.Text = idUsuario;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Usuario usuario = new Usuario();
                usuario.Eliminar(txtIdUsuario.Text);
                usuario.ObtenerLista(dgvUsuarios);
                MessageBox.Show("Usuario Eliminado");
            }
            else
            {
                MessageBox.Show("No se elminio el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
