using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Cliente
    {

        MP_Cliente mapper = new MP_Cliente();

        public int AltaCliente(Cliente cliente) 
        {
            return mapper.AltaCliente(cliente);
        }

        public int BajaCliente(Cliente cliente)
        {
            return mapper.BajaCliente(cliente);
        }

        public int ModificarCliente(Cliente cliente)
        {
            return mapper.ModificarCliente(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return mapper.ListarClientes();
        }

        public int CalcularIdCliente() 
        {
            List<Cliente> clientes = ListarClientes();
            int id = 0;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.IdCliente > id)
                    id = cliente.IdCliente;
            }

            return id + 1;
        }

        public void ExportarXml() 
        {
            mapper.ExportarXml();
        }

    }
}
