using BLL;
using System;
using System.Net.NetworkInformation;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Quilo3D
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        BLL_Login gestorLogin = new BLL_Login();

        private void VerificarServicioSQL()
        {
            try
            {
                if (scSQL.Status != ServiceControllerStatus.Running)
                {
                    MessageBox.Show(
                        "El servicio SQL Server se encuentra detenido, inicielo antes de continuar.",
                        "SQL Server Detenido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "El servicio SQL Server está en ejecución.",
                        "SQL Server en ejecución",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al verificar el estado del servicio SQL Server: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool VerificarConexionRed()
        {
            try
            {
                bool redConectada = NetworkInterface.GetIsNetworkAvailable();

                if (redConectada)
                {
                    MessageBox.Show("El usuario está conectado a la red.",
                                    "Conexión a la red",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario no está conectado a la red. Por favor, verifica tu conexión.",
                                    "Sin conexión a la red",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                return redConectada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al verificar la conexión a la red: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contrasena = txtContraseniaUsuario.Text;
            if (!VerificarConexionRed())
            {
                return;
            }
            VerificarServicioSQL();
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

        private void btnNavegarInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/quilo.ba/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
