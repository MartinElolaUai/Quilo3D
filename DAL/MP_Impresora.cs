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
    public class MP_Impresora
    {
        Acceso acceso = new Acceso();

        public int AltaImpresora(Impresora impresora) 
        {
            SqlParameter[] parametros = new SqlParameter[3]
            {
                new SqlParameter("@IdImpresora", impresora.IdImpresora),
                new SqlParameter ("@ConsumoElectricoHr", impresora.ConsumoElectrico),
                new SqlParameter ("@Descripcion", impresora.Descripcion)
            };

            return acceso.Escribir("AltaImpresora", parametros);

        }
    
        public int BajaImpresora(Impresora impresora)
        {
            SqlParameter[] parametros = new SqlParameter[1]
            {
                new SqlParameter("@IdImpresora", impresora.IdImpresora)
            };

            return acceso.Escribir("BajaImpresora", parametros);
        }

        public int ModificarImpresora(Impresora impresora)
        {
            SqlParameter[] parametros = new SqlParameter[3]
            {
                new SqlParameter("@IdImpresora", impresora.IdImpresora),
                new SqlParameter("@ConsumoElectricoHr", impresora.ConsumoElectrico),
                new SqlParameter("@Descripcion", impresora.Descripcion)
            };

            return acceso.Escribir("ModificarImpresora", parametros);
        }

        public List<Impresora> ListarImpresoras()
        {
            List<Impresora> impresoras = new List<Impresora>();
            DataTable dt = acceso.Leer("ListarImpresoras", null);

            foreach (DataRow dr in dt.Rows) 
            {
                Impresora impresora = new Impresora();
                impresora.IdImpresora = Convert.ToInt32(dr["IdImpresora"]);
                impresora.ConsumoElectrico = Convert.ToInt32(dr["ConsumoElectrico"]);
                impresora.Descripcion = dr["Descripcion"].ToString();

                impresoras.Add(impresora);
            }

            return impresoras;
        }

        public void ExportarXml() 
        {
            acceso.ExportarSPXML("ListarImpresoras", "Impresoras", null);
        }

    }
}
