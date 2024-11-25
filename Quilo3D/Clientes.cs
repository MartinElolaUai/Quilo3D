using BE;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            ActualizarListaClientes();
        }

        BLL_Cliente gestorCliente = new BLL_Cliente();

        private void ActualizarListaClientes()
        {
            dgvListaClientes.DataSource = null;
            dgvListaClientes.DataSource = gestorCliente.ListarClientes();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
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

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = dgvListaClientes.CurrentRow.DataBoundItem as Cliente;
            txtNombreCliente.Text = cliente.Nombre;
            txtApellidoCliente.Text = cliente.Apellido;
            txtDniCliente.Text = cliente.Dni.ToString();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            QUILO3D formularioQuilo3D = new QUILO3D();
            formularioQuilo3D.Show();
            this.Hide();
        }
    }
}
