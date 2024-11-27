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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ActualizarListaVentas();
            InicializarRecaudadoGanancia();
            drFiltroVentas.FiltrarClick += DateRangePicker_FiltrarClick;
        }

        BLL_Venta gestorVenta = new BLL_Venta();

        private void ActualizarListaVentas()
        {
            dgvListaVentas.DataSource = null;
            dgvListaVentas.DataSource = gestorVenta.ListarVentas();
            ConfigurarOrdenColumnas();
        }

        private void InicializarRecaudadoGanancia() 
        {
            txtTotalRecaudado.Text = "$ " + gestorVenta.CalcularTotalRecaudado().ToString();
            txtGananciaTotal.Text = "$ " + (gestorVenta.CalcularTotalGanancia()).ToString();
        }

        private void InicializarRecaudadoGanancia(DateTime fechaInicio, DateTime fechaFin)
        {
            txtTotalRecaudado.Text = "$ " + gestorVenta.CalcularTotalRecaudado(fechaInicio, fechaFin).ToString();
            txtGananciaTotal.Text = "$ " + (gestorVenta.CalcularTotalGanancia(fechaInicio, fechaFin)).ToString();
        }

        private void DateRangePicker_FiltrarClick(object sender, EventArgs e)
        {
            var dateRangePicker = sender as DateRange;

            DateTime fechaInicio = dateRangePicker.FechaInicio;
            DateTime fechaFin = dateRangePicker.FechaFin;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (fechaInicio > DateTime.Now) 
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvListaVentas.DataSource = null;
            dgvListaVentas.DataSource = gestorVenta.ListarVentas(fechaInicio, fechaFin);
            InicializarRecaudadoGanancia(fechaInicio, fechaFin);
            ConfigurarOrdenColumnas();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = drFiltroVentas.FechaInicio;
            DateTime fechaFin = drFiltroVentas.FechaFin;

            gestorVenta.ExportarXml(fechaInicio, fechaFin);
        }

        private void ConfigurarOrdenColumnas()
        {
            dgvListaVentas.Columns["IdVenta"].DisplayIndex = 0;
            dgvListaVentas.Columns["Descripcion"].DisplayIndex = 1;
            dgvListaVentas.Columns["Valor"].DisplayIndex = 2;
            dgvListaVentas.Columns["FechaVenta"].DisplayIndex = 3;
            dgvListaVentas.Columns["IdProducto"].DisplayIndex = 4; 
            dgvListaVentas.Columns["IdCliente"].DisplayIndex = 5; 
        }

        private void btnFiltrarLista_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = drFiltroVentas.FechaInicio;
            DateTime fechaFin = drFiltroVentas.FechaFin;
            dgvListaVentas.DataSource = null;
            dgvListaVentas.DataSource = gestorVenta.ListarVentas(fechaInicio, fechaFin);
            InicializarRecaudadoGanancia();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarListaVentas();
            InicializarRecaudadoGanancia();
        }

    }
}
