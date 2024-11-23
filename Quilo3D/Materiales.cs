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

        private void dgvListaMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
