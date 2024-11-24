using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace Quilo3D
{
    public partial class Impresoras : Form
    {

        BLL_Impresora gestorImpresora = new BLL_Impresora();
        BLL_Material gestorMaterial = new BLL_Material();

        public Impresoras()
        {
            InitializeComponent();
            ActualizarListaImpresoras();
        }

        public void ActualizarListaImpresoras() 
        {
            dgvListaImpresoras.DataSource = null;
            dgvListaImpresoras.DataSource = gestorImpresora.ListarImpresoras();
        }

        private void btnAgregarImpresora_Click(object sender, EventArgs e)
        {
            Impresora impresora = new Impresora();
            impresora.Descripcion = txtDescripcion.Text;
            impresora.ConsumoElectrico = Convert.ToInt32(txtConsumoElectrico.Text);
            impresora.IdImpresora = gestorImpresora.CalcularIdImpresora();

            gestorImpresora.AltaImpresora(impresora);
            ActualizarListaImpresoras();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Impresora impresora = dgvListaImpresoras.CurrentRow.DataBoundItem as Impresora;
            gestorImpresora.BajaImpresora(impresora);
            ActualizarListaImpresoras();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }
    }
}
