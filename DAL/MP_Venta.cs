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
                new SqlParameter("@Valor", Convert.ToDecimal(venta.Valor)),
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

        public List<Venta> ListarVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> ventas = new List<Venta>();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@FechaInicio", fechaInicio),
                new SqlParameter("@FechaFin", fechaFin)
            };

            DataTable dt = acceso.Leer("ListarVentasPorFecha", parametros);

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

        public void ExportarXML(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@FechaInicio", fechaInicio),
                new SqlParameter("@FechaFin", fechaFin)
            };
            acceso.ExportarSPXML("ListarVentasPorFecha", "VentasFiltradas", parametros);
        }

    }
}
