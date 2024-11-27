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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Impresoras_Load(object sender, EventArgs e)
        {
            ActualizarListaImpresoras();
        }

        public void ActualizarListaImpresoras() 
        {
            dgvListaImpresoras.DataSource = null;
            dgvListaImpresoras.DataSource = gestorImpresora.ListarImpresoras();
            ConfigurarOrdenColumnas();
        }

        private void btnAgregarImpresora_Click(object sender, EventArgs e)
        {
            Impresora impresora = new Impresora();
            if (!ValidarCampos())
                return;
            impresora.Descripcion = txtDescripcion.Text;
            impresora.ConsumoElectrico = Convert.ToInt32(txtConsumoElectrico.Text);
            impresora.IdImpresora = gestorImpresora.CalcularIdImpresora();

            gestorImpresora.AltaImpresora(impresora);
            ActualizarListaImpresoras();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Impresora impresora = dgvListaImpresoras.CurrentRow.DataBoundItem as Impresora;
            if (impresora != null)
            {
                gestorImpresora.BajaImpresora(impresora);
                ActualizarListaImpresoras();
            }
            else
            {
                MessageBox.Show("Seleccione una impresora válida para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private void ConfigurarOrdenColumnas()
        {
            dgvListaImpresoras.Columns["IdImpresora"].DisplayIndex = 0;
            dgvListaImpresoras.Columns["ConsumoElectrico"].DisplayIndex = 1;
            dgvListaImpresoras.Columns["Descripcion"].DisplayIndex = 2;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Impresora impresora = dgvListaImpresoras.CurrentRow.DataBoundItem as Impresora;
            if (impresora == null)
            {
                MessageBox.Show("Seleccione una impresora válida para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidarCampos())
                return;

            impresora.Descripcion = txtDescripcion.Text;
            impresora.ConsumoElectrico = Convert.ToInt32(txtConsumoElectrico.Text);

            gestorImpresora.ModificarImpresora(impresora);
            ActualizarListaImpresoras();
        }

        private bool ValidarCampos() 
        {
            if (txtConsumoElectrico.Text == "" || txtDescripcion.Text == "" )
            {
                MessageBox.Show("Complete todos los campos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtConsumoElectrico.Text, out _)) 
            {
                MessageBox.Show("El Consumo Eléctrico debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dgvListaImpresoras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtConsumoElectrico.Text = dgvListaImpresoras.Rows[e.RowIndex].Cells["ConsumoElectrico"].Value.ToString();
            txtDescripcion.Text = dgvListaImpresoras.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
        }

        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            gestorImpresora.ExportarXml();
        }

    }
}
