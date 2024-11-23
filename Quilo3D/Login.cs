using BLL;
using System;
using System.Windows.Forms;

namespace Quilo3D
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BLL_Login gestorLogin = new BLL_Login();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contrasena = txtContraseniaUsuario.Text;

            try
            {
                bool loginExitoso = gestorLogin.ValidarUsuario(usuario, contrasena);
                if (loginExitoso)
                {
                    QUILO3D formularioQuilo3D = new QUILO3D();
                    formularioQuilo3D.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void logoQuilo_Click(object sender, EventArgs e)
        {

        }
    }
}
