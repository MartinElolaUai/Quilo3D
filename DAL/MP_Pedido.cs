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
    public class MP_Pedido
    {
        Acceso acceso = new Acceso();

        public int AltaProducto(Pedido producto)
        {
            SqlParameter[] parametros = new SqlParameter[6]
            {
                new SqlParameter("@IdProducto", producto.IdProducto),
                new SqlParameter("@IdImpresora", producto.IdImpresora),
                new SqlParameter("@IdMaterial", producto.IdMaterial),
                new SqlParameter("@TiempoImpresion", Convert.ToDecimal(producto.TiempoImpresion)),
                new SqlParameter("@Peso", Convert.ToDecimal(producto.Peso)),
                new SqlParameter("@Costo", Convert.ToDecimal(producto.Costo))
            };

            return acceso.Escribir("AltaProducto", parametros);
        }

        public List<Pedido> ListarProductos()
        {
            List<Pedido> productos = new List<Pedido>();
            DataTable dt = acceso.Leer("ListarProductos", null);

            foreach (DataRow dr in dt.Rows)
            {
                Pedido producto = new Pedido();
                producto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                producto.IdImpresora = Convert.ToInt32(dr["IdImpresora"]);
                producto.IdMaterial = Convert.ToInt32(dr["IdMaterial"]);
                producto.TiempoImpresion = Convert.ToDouble(dr["TiempoImpresion"]);
                producto.Peso = Convert.ToDouble(dr["Peso"]);
                producto.Costo = Convert.ToDouble(dr["Costo"]);

                productos.Add(producto);
            }

            return productos;
        }

        public void ExportarXml() 
        {
            acceso.ExportarSPXML("ListarProductos", "Pedidos", null);
        }

    }
}
