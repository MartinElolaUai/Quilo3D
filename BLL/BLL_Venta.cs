using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Venta
    {
        MP_Venta mapper = new MP_Venta();

        public int AltaVenta(Venta venta)
        {
            return mapper.AltaVenta(venta);
        }

        public List<Venta> ListarVentas()
        {
            return mapper.ListarVentas();
        }

        public int CalcularIdVenta() 
        {
            List<Venta> ventas = ListarVentas();
            int id = 0;

            foreach (Venta venta in ventas)
            {
                if (venta.IdVenta > id)
                    id = venta.IdVenta;
            }

            return id + 1;
        }

    }
}
