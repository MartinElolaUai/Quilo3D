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

    }
}
