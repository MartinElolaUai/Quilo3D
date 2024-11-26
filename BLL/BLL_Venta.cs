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

        public List<Venta> ListarVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            return mapper.ListarVentas(fechaInicio, fechaFin);
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

        public void ExportarXml(DateTime fechaInicio, DateTime fechaFin) 
        {
            mapper.ExportarXML(fechaInicio, fechaFin);
        }

        public double CalcularTotalRecaudado()
        {
            List<Venta> ventas = ListarVentas();
            double total = 0;

            foreach (Venta venta in ventas)
            {
                total += venta.Valor;
            }

            return total;
        }

        public double CalcularTotalRecaudado(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> ventas = ListarVentas(fechaInicio, fechaFin);
            double total = 0;

            foreach (Venta venta in ventas)
            {
                total += venta.Valor;
            }

            return total;
        }

        public double CalcularTotalGanancia()
        {
            double total = CalcularTotalRecaudado();
            return total * 0.3;
        }

        public double CalcularTotalGanancia(DateTime fechaInicio, DateTime fechaFin)
        {
            double total = CalcularTotalRecaudado(fechaInicio, fechaFin);
            return total * 0.3;
        }

    }
}
