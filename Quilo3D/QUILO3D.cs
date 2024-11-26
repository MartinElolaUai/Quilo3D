using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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

        private void btnImpresoras_Click(object sender, EventArgs e)
        {
            Impresoras impresoras = new Impresoras();
            impresoras.Show();
            this.Hide();
        }

        private void btnMenuMateriales_Click(object sender, EventArgs e)
        {
            Materiales materiales = new Materiales();
            materiales.Show();
            this.Hide();
        }

        private void btnMenuPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }
        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }
    }
}
