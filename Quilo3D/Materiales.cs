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
    public partial class Materiales : Form
    {
        public Materiales()
        {
            InitializeComponent();
            ActualizarListaMateriales();
        }

        BLL_Material gestorMaterial = new BLL_Material();

        public void ActualizarListaMateriales()
        {
            dgvListaMateriales.DataSource = null;
            dgvListaMateriales.DataSource = gestorMaterial.ListarMateriales();
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            decimal pesoKg = Convert.ToDecimal(txtPesoKg.Text);
            string tipo = cmbTipoMaterial.Text;
            material.IdMaterial = gestorMaterial.CalcularIdMaterial();
            material.Color = txtColor.Text;
            material.PesoKg = pesoKg;
            material.Tipo = tipo;
            material.Costo = gestorMaterial.CalcularCosto(tipo, pesoKg);

            gestorMaterial.AltaMaterial(material);
            ActualizarListaMateriales();
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            Material material = dgvListaMateriales.CurrentRow.DataBoundItem as Material;
            gestorMaterial.BajaMaterial(material);
            
            ActualizarListaMateriales();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }
    }
}
