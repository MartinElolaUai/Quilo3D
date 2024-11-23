using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InicializarComboboxMaterial();
        }

        public void ActualizarListaImpresoras() 
        {
            dgvListaImpresoras.DataSource = null;
            dgvListaImpresoras.DataSource = gestorImpresora.ListarImpresoras();
        }

        public void InicializarComboboxMaterial()
        {
            cmbMaterial.DataSource = null;
            cmbMaterial.DataSource = gestorMaterial.ListarMateriales();
            cmbMaterial.DisplayMember = "Tipo";
        }

        private void btnAgregarImpresora_Click(object sender, EventArgs e)
        {
            Impresora impresora = new Impresora();
            Material material = cmbMaterial.SelectedItem as Material;
            impresora.IdMaterial = material.IdMaterial;
            impresora.Descripcion = txtDescripcion.Text;
            impresora.ConsumoElectrico = Convert.ToInt32(txtConsumoElectrico.Text);
            impresora.IdImpresora = gestorImpresora.CalcularIdImpresora();

            gestorImpresora.AltaImpresora(impresora);
            ActualizarListaImpresoras();
        }
    }
}
