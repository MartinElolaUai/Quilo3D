﻿using BE;
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

        private void dgvListaImpresoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Impresora impresora = dgvListaImpresoras.CurrentRow.DataBoundItem as Impresora;
            txtDescripcion.Text = impresora.Descripcion;
            txtConsumoElectrico.Text = impresora.ConsumoElectrico.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Impresora impresora = dgvListaImpresoras.CurrentRow.DataBoundItem as Impresora;
            impresora.Descripcion = txtDescripcion.Text;
            impresora.ConsumoElectrico = Convert.ToInt32(txtConsumoElectrico.Text);

            gestorImpresora.ModificarImpresora(impresora);
            ActualizarListaImpresoras();
        }
    }
}
