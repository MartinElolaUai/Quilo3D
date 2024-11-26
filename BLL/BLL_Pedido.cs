using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Pedido
    {

        MP_Pedido mapper = new MP_Pedido();

        public int AltaProducto(Pedido producto)
        {
            return mapper.AltaProducto(producto);
        }

        public List<Pedido> ListarProductos()
        {
            return mapper.ListarProductos();
        }

        public int CalcularIdProducto()
        {
            List<Pedido> productos = ListarProductos();
            int id = 0;

            foreach (Pedido producto in productos)
            {
                if (producto.IdProducto > id)
                    id = producto.IdProducto;
            }

            return id + 1;
        }

        public double CalcularCostoTotalProducto(int idImpresora, double tiempoTotalImpresion, string material, double pesoEnKilos) 
        {
            BLL_Impresora gestorImpresora = new BLL_Impresora();
            BLL_Material gestorMaterial = new BLL_Material();
            return gestorImpresora.CalcularCostoTotalLuz(tiempoTotalImpresion, idImpresora) + gestorMaterial.CalcularCosto(material, pesoEnKilos);
        }

        public double CalcularValorTotalProducto(double costoTotal) 
        {
            // A todos los productos se le saca una ganancia del 30%
            return costoTotal * 1.3;
        }

        public void ExportarXml()
        {
            mapper.ExportarXml();
        }

    }
}
