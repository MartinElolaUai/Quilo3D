using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Cliente
    {
        Acceso acceso = new Acceso();

        public int AltaCliente(Cliente cliente) 
        {
            SqlParameter[] parametros = new SqlParameter[4] 
            {
                new SqlParameter("@IdCliente", cliente.IdCliente),
                new SqlParameter("@Nombre", cliente.Nombre),
                new SqlParameter("@Apellido", cliente.Apellido),
                new SqlParameter("@Dni", cliente.Dni)
            };
        
            return acceso.Escribir("AltaCliente", parametros);
        }

        public int BajaCliente(Cliente cliente)
        {
            SqlParameter[] parametros = new SqlParameter[1]
            {
                new SqlParameter("@IdCliente", cliente.IdCliente)
            };

            return acceso.Escribir("BajaCliente", parametros);
        }

        public int ModificarCliente(Cliente cliente)
        {
            SqlParameter[] parametros = new SqlParameter[4]
            {
                new SqlParameter("@IdCliente", cliente.IdCliente),
                new SqlParameter("@Nombre", cliente.Nombre),
                new SqlParameter("@Apellido", cliente.Apellido),
                new SqlParameter("@Dni", cliente.Dni)
            };

            return acceso.Escribir("ModificarCliente", parametros);
        }

        public List<Cliente> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable dt = acceso.Leer("ListarClientes", null);

            foreach (DataRow dr in dt.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                cliente.Nombre = dr["Nombre"].ToString();
                cliente.Apellido = dr["Apellido"].ToString();
                cliente.Dni = Convert.ToInt32(dr["Dni"]);

                clientes.Add(cliente);
            }

            return clientes;
        }

        public void ExportarXml() 
        {
            acceso.ExportarSPXML("ListarClientes", "Clientes", null);
        }

    }
}
