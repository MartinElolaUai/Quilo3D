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
    public partial class QUILO3D : Form
    {
        public QUILO3D()
        {
            InitializeComponent();
        }

        BLL_Impresora gestorImpresora = new BLL_Impresora();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void InicializarComboboxImpresoras() 
        {
            cmbImpresorasDisponibles.DataSource = null;
            cmbImpresorasDisponibles.DataSource = gestorImpresora.ListarImpresoras();

            cmbImpresorasDisponibles.DisplayMember = "Descripcion";
        }

        private void btnProcesarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnGestorImpresora_Click(object sender, EventArgs e)
        {
            Impresoras formularioImpresoras = new Impresoras();
            formularioImpresoras.Show();
            this.Hide();
        }

        private void btnGestorMaterial_Click(object sender, EventArgs e)
        {
            Materiales formularioMateriales = new Materiales();
            formularioMateriales.Show();
            this.Hide();
        }
    }
}
