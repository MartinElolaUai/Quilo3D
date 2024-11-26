﻿using BE;
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
            InicializarComboboxClientes();
            ActualizarListaProductos();
        }

        BLL_Impresora gestorImpresora = new BLL_Impresora();
        BLL_Producto gestorProducto = new BLL_Producto();
        BLL_Material gestorMaterial = new BLL_Material();
        BLL_Cliente gestorCliente = new BLL_Cliente();
        BLL_Venta gestorVenta = new BLL_Venta();

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
            Venta venta = new Venta();
            Cliente cliente = cmbSeleccionarCliente.SelectedItem as Cliente;
            if (!ValidarCampos())
                return;

            string pesoTexto = Regex.Replace(txtPesoProducto.Text, "\\.", ",");
            double pesoKg = Convert.ToDouble(pesoTexto);
            double costoTotal = gestorProducto.CalcularCostoTotalProducto(producto.IdImpresora, producto.TiempoImpresion, material.Tipo, pesoKg);
            double valorTotal = gestorProducto.CalcularValorTotalProducto(costoTotal);

            /* ALTA PRODUCTO */
            producto.IdProducto = gestorProducto.CalcularIdProducto();
            producto.Peso = pesoKg;
            producto.TiempoImpresion = gestorImpresora.CalcularTiempoTotalImpresion(pesoKg);
            producto.IdImpresora = impresora.IdImpresora;
            producto.IdMaterial = material.IdMaterial;
            producto.Costo = costoTotal;
            gestorProducto.AltaProducto(producto);

            /* ALTA VENTA */
            venta.IdVenta = gestorVenta.CalcularIdVenta();
            venta.IdCliente = cliente.IdCliente;
            venta.IdProducto = producto.IdProducto;
            venta.Valor = valorTotal;
            venta.FechaVenta = DateTime.Now.Date;
            venta.Descripcion = null;
            venta.Descripcion = txtDescripcionVenta.Text;
            gestorVenta.AltaVenta(venta);
            
            ActualizarListaProductos();
            ActualizarDatosProducto(costoTotal.ToString(), producto.TiempoImpresion.ToString(), valorTotal.ToString());
        }

        private void ActualizarDatosProducto(string costoTotal, string tiempoImpresion, string valorImpresion)
        {
            txtCostoImpresion.Text = "$ " + costoTotal;
            txtTiempoImpresion.Text = tiempoImpresion + " horas";
            txtValorImpresion.Text = "$ " + valorImpresion;
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto producto = dgvListaProductos.CurrentRow.DataBoundItem as Producto;
            ActualizarDatosProducto(producto.Costo.ToString(), producto.TiempoImpresion.ToString(), gestorProducto.CalcularValorTotalProducto(producto.Costo).ToString());
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private bool ValidarCampos()
        {
            if (txtPesoProducto.Text == "" || txtDescripcionVenta.Text == "" || cmbSeleccionarCliente.Text == "" || cmbMaterial.Text == "" ||
                cmbImpresorasDisponibles.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtPesoProducto.Text, out _)) 
            {
                MessageBox.Show("El campo 'Peso en Kg' debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }


        /* INICIALIZADORES DE COMBOBOX */

        public void InicializarComboboxImpresoras()
        {
            cmbImpresorasDisponibles.DataSource = null;
            cmbImpresorasDisponibles.DataSource = gestorImpresora.ListarImpresoras();

            cmbImpresorasDisponibles.DisplayMember = "Descripcion";
        }

        public void InicializarComboboxClientes()
        {
            cmbSeleccionarCliente.DataSource = null;
            cmbSeleccionarCliente.DataSource = gestorCliente.ListarClientes();

            cmbSeleccionarCliente.DisplayMember = "ApellidoDni";
        }

        public void InicializarComboboxMaterial()
        {
            cmbMaterial.DataSource = null;
            cmbMaterial.DataSource = gestorMaterial.ListarMateriales();

            cmbMaterial.DisplayMember = "TipoColor";
        }

        private void dgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Producto producto = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as Producto;
            ActualizarDatosProducto(producto.Costo.ToString(), producto.TiempoImpresion.ToString(), gestorProducto.CalcularValorTotalProducto(producto.Costo).ToString());
        }
    }
}
