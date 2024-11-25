using BE;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Impresora
    {
    
        MP_Impresora mapper = new MP_Impresora();
        public int AltaImpresora(Impresora impresora)
        {
            return mapper.AltaImpresora(impresora);
        }

        public int BajaImpresora(Impresora impresora)
        {
            return mapper.BajaImpresora(impresora);
        }

        public int ModificarImpresora(Impresora impresora)
        {
            return mapper.ModificarImpresora(impresora);
        }

        public List<Impresora> ListarImpresoras()
        {
            return mapper.ListarImpresoras();
        }

        public int CalcularIdImpresora()
        {
            List<Impresora> impresoras = ListarImpresoras();
            int id = 0;

            foreach (Impresora impresora in impresoras)
            {
                if (impresora.IdImpresora > id)
                    id = impresora.IdImpresora;
            }

            return id + 1;
        }

        public double CalcularTiempoTotalImpresion(double pesoProducto) 
        {
            double materialImpresoPorHora = 0.1;
            double tiempoTotalImpresion = pesoProducto / materialImpresoPorHora;

            return tiempoTotalImpresion;
        }

        public double CalcularCostoTotalLuz(double tiempoTotalImpresion, int idImpresora)
        {
            List<Impresora> impresoras = ListarImpresoras();
            double consumoTotalElectrico = 0;
            double costoLuzPor100W = 150; // $150 por 100W por hora
            double costoTotalLuz = 0;

            foreach (Impresora impresora in impresoras)
            {
                if (impresora.IdImpresora == idImpresora)
                {
                    consumoTotalElectrico = impresora.ConsumoElectrico * tiempoTotalImpresion;
                    double costoLuzPorHora = (consumoTotalElectrico / 100) * costoLuzPor100W;
                    costoTotalLuz = costoLuzPorHora * tiempoTotalImpresion;
                }
            }

            return costoTotalLuz;
        }

    }
}
