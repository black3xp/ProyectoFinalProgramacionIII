namespace ProyectoFinal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pictLogin.Left = (this.ClientSize.Width - pictLogin.Width) / 2;
            txtPassword.Left = (this.ClientSize.Width - txtPassword.Width) / 2;
            txtUsuario.Left = (this.ClientSize.Width - txtUsuario.Width) / 2;
            btnEntrar.Left = (this.ClientSize.Width - btnEntrar.Width) / 2;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            if(txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var login = Usuario.Login(txtUsuario.Text, txtPassword.Text);

            if (login)
            {
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no coinciden", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLogin_Enter(object sender, EventArgs e)
        {
 
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmMain frmMain = new frmMain();
                if (txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Ingrese usuario y contraseña", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var login = Usuario.Login(txtUsuario.Text, txtPassword.Text);

                if (login)
                {
                    frmMain.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no coinciden", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}