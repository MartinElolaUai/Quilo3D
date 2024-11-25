using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Venta
    {
        Acceso acceso = new Acceso();

        public int AltaVenta(Venta venta) 
        {
            SqlParameter[] parametros = new SqlParameter[6]
            {
                new SqlParameter("@IdVenta", venta.IdVenta),
                new SqlParameter("@IdCliente", venta.IdCliente),
                new SqlParameter("@IdProducto", venta.IdProducto),
                new SqlParameter("@Valor", venta.Valor),
                new SqlParameter("@FechaVenta", venta.FechaVenta),
                new SqlParameter("@Descripcion", venta.Descripcion)
            };

            return acceso.Escribir("AltaVenta", parametros);
        }

        public List<Venta> ListarVentas()
        {
            List<Venta> ventas = new List<Venta>();
            DataTable dt = acceso.Leer("ListarVentas", null);

            foreach (DataRow dr in dt.Rows)
            {
                Venta venta = new Venta();

                venta.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                venta.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                venta.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                venta.Valor = Convert.ToDouble(dr["Valor"]);
                venta.FechaVenta = Convert.ToDateTime(dr["FechaVenta"]);
                venta.Descripcion = Convert.ToString(dr["Descripcion"]);

                ventas.Add(venta);
            }

            return ventas;
        }



    }
}
