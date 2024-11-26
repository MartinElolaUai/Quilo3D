using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            dgvListaMateriales.AsignarDatos(gestorMaterial.ListarMateriales());
            ConfigurarOrdenColumnas();
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            if (!ValidarCampos())
                return;

            string pesoTexto = Regex.Replace(txtPesoKg.Text, "\\.", ",");
            double pesoKg = Convert.ToDouble(pesoTexto);
            string tipo = cmbTipoMaterial.Text;

            material.IdMaterial = gestorMaterial.CalcularIdMaterial();
            material.Color = txtColor.Text;
            material.PesoKg = pesoKg;
            material.Tipo = tipo;
            material.Costo = gestorMaterial.CalcularCosto(tipo, pesoKg);

            gestorMaterial.AltaMaterial(material);
            ActualizarListaMateriales();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private bool ValidarCampos() 
        {
            if (txtColor.Text == "" || txtPesoKg.Text == "" || cmbTipoMaterial.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtPesoKg.Text, out _)) 
            {
                MessageBox.Show("El campo 'Peso en Kg' debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void btnModificarMaterial_Click(object sender, EventArgs e)
        {
            Material material = dgvListaMateriales.CurrentRow.DataBoundItem as Material;
            if (material == null)
            {
                MessageBox.Show("Seleccione un material válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidarCampos())
                return;
            material.Color = txtColor.Text;
            material.PesoKg = Convert.ToDouble(txtPesoKg.Text);
            material.Tipo = cmbTipoMaterial.Text;
            material.Costo = gestorMaterial.CalcularCosto(material.Tipo, material.PesoKg);

            gestorMaterial.ModificarMaterial(material);
            ActualizarListaMateriales();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarListaMateriales();
        }

        private void btnFiltrarLista_Click(object sender, EventArgs e)
        {
            dgvListaMateriales.DataSource = null;
            dgvListaMateriales.DataSource = gestorMaterial.ListarMateriales(cmbTipoMaterial.Text);
            ConfigurarOrdenColumnas();
        }

        private void btnMenuAtras_Click_1(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            if (cmbTipoMaterial.Text != "")
            {
                gestorMaterial.ExportarXml(cmbTipoMaterial.Text);
            }
            else 
            {
                gestorMaterial.ExportarXml();
            }
        }

        private void ConfigurarOrdenColumnas()
        {
            dgvListaMateriales.Columns["Tipo"].DisplayIndex = 2;
            dgvListaMateriales.Columns["Color"].DisplayIndex = 3;
            dgvListaMateriales.Columns["PesoKg"].DisplayIndex = 4;
            dgvListaMateriales.Columns["Costo"].DisplayIndex = 5;
            dgvListaMateriales.Columns["IdMaterial"].DisplayIndex = 1;
            dgvListaMateriales.Columns["TipoColor"].Visible = false;
        }

        private void dgvListaMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtColor.Text = dgvListaMateriales.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            txtPesoKg.Text = dgvListaMateriales.Rows[e.RowIndex].Cells["PesoKg"].Value.ToString();
            cmbTipoMaterial.Text = dgvListaMateriales.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();

            if (e.ColumnIndex == dgvListaMateriales.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas realizar esta acción?",
                                                    "Confirmar Acción",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    Material material = dgvListaMateriales.CurrentRow.DataBoundItem as Material;
                    gestorMaterial.BajaMaterial(material);
                    ActualizarListaMateriales();
                }
            }   
        }
    }
}
