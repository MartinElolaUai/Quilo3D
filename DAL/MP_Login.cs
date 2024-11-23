using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Login
    {
        Acceso acceso = new Acceso();

        public DataTable ValidarUsuario(string usuario, string contrasenia)
        {            
            SqlParameter[] parametros = new SqlParameter[2]
            {
                new SqlParameter("@NombreUsuario", usuario),
                new SqlParameter("@Contrasenia", contrasenia)
            };

            return acceso.Leer("ValidarUsuario", parametros);
        }

    }
}
