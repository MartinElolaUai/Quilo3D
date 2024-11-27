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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }

        BLL_Cliente gestorCliente = new BLL_Cliente();

        private void ActualizarListaClientes()
        {
            dgvListaClientes.DataSource = null;
            dgvListaClientes.DataSource = gestorCliente.ListarClientes();
            ConfigurarOrdenColumnas();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (!ValidarCampos())
                return;
            cliente.IdCliente = gestorCliente.CalcularIdCliente();
            cliente.Nombre = txtNombreCliente.Text;
            cliente.Apellido = txtApellidoCliente.Text;
            cliente.Dni = Convert.ToInt32(txtDniCliente.Text);

            gestorCliente.AltaCliente(cliente);
            ActualizarListaClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = dgvListaClientes.CurrentRow.DataBoundItem as Cliente;
            if (cliente != null)
            {
                cliente.Nombre = txtNombreCliente.Text;
                cliente.Apellido = txtApellidoCliente.Text;
                cliente.Dni = Convert.ToInt32(txtDniCliente.Text);

                gestorCliente.ModificarCliente(cliente);
                ActualizarListaClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = dgvListaClientes.CurrentRow.DataBoundItem as Cliente;
            if (cliente != null) 
            {
                gestorCliente.BajaCliente(cliente);
                ActualizarListaClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }

        private bool ValidarCampos() 
        {
            if (txtNombreCliente.Text == "" || txtApellidoCliente.Text == "" || txtDniCliente.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtDniCliente.Text, out _))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidDni(txtDniCliente.Text))
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        public bool IsValidDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return false;

            string dniPattern = @"^\d{7,8}$";
            return Regex.IsMatch(dni, dniPattern);
        }

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtNombreCliente.Text = dgvListaClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellidoCliente.Text = dgvListaClientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtDniCliente.Text = dgvListaClientes.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
        }

        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            gestorCliente.ExportarXml();
        }

        private void ConfigurarOrdenColumnas()
        {
            dgvListaClientes.Columns["IdCliente"].DisplayIndex = 0;
            dgvListaClientes.Columns["Nombre"].DisplayIndex = 1;
            dgvListaClientes.Columns["Apellido"].DisplayIndex = 2;
            dgvListaClientes.Columns["Dni"].DisplayIndex = 3;
            dgvListaClientes.Columns["ApellidoDni"].DisplayIndex = 4;
            dgvListaClientes.Columns["ApellidoDni"].Visible = false;
        }

    }
}
