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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            ActualizarListaVentas();
        }

        BLL_Venta gestorVenta = new BLL_Venta();

        private void ActualizarListaVentas()
        {
            dgvListaVentas.DataSource = null;
            dgvListaVentas.DataSource = gestorVenta.ListarVentas();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
