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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            InicializarComboboxImpresoras();
            InicializarComboboxMaterial();
            ActualizarListaProductos();
        }

        BLL_Impresora gestorImpresora = new BLL_Impresora();
        BLL_Producto gestorProducto = new BLL_Producto();
        BLL_Material gestorMaterial = new BLL_Material();

        public void InicializarComboboxImpresoras() 
        {
            cmbImpresorasDisponibles.DataSource = null;
            cmbImpresorasDisponibles.DataSource = gestorImpresora.ListarImpresoras();

            cmbImpresorasDisponibles.DisplayMember = "Descripcion";
        }

        public void InicializarComboboxMaterial()
        {
            cmbMaterial.DataSource = null;
            cmbMaterial.DataSource = gestorMaterial.ListarMateriales();

            cmbMaterial.DisplayMember = "TipoColor";
        }

        public void ActualizarListaProductos()
        {
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = gestorProducto.ListarProductos();
        }

        private void btnProcesarPedido_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            Impresora impresora = cmbImpresorasDisponibles.SelectedItem as Impresora;
            Material material = cmbMaterial.SelectedItem as Material;

            string pesoTexto = Regex.Replace(txtPesoProducto.Text, "\\.", ",");
            double pesoKg = Convert.ToDouble(pesoTexto);
            double costoTotal = gestorProducto.CalcularCostoTotalProducto(producto.IdImpresora, producto.TiempoImpresion, material.Tipo, pesoKg);
            double valorTotal = gestorProducto.CalcularValorTotalProducto(costoTotal);

            producto.IdProducto = gestorProducto.CalcularIdProducto();
            producto.Peso = pesoKg;
            producto.TiempoImpresion = gestorImpresora.CalcularTiempoTotalImpresion(pesoKg);
            producto.IdImpresora = impresora.IdImpresora;
            producto.IdMaterial = material.IdMaterial;
            producto.Costo = costoTotal;

            txtCostoImpresion.Text = "$ " +  costoTotal.ToString();
            txtTiempoImpresion.Text = producto.TiempoImpresion.ToString() + " horas";
            txtValorImpresion.Text = "$ " + valorTotal.ToString();

            gestorProducto.AltaProducto(producto);
            ActualizarListaProductos();
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto producto = dgvListaProductos.CurrentRow.DataBoundItem as Producto;
            txtCostoImpresion.Text = "$ " + producto.Costo.ToString();
            txtTiempoImpresion.Text = producto.TiempoImpresion.ToString() + " horas";
            txtValorImpresion.Text = "$ " + gestorProducto.CalcularValorTotalProducto(producto.Costo).ToString();
            txtPesoProducto.Text = producto.Peso.ToString();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }
    }
}
