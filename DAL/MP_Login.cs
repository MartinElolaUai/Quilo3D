using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Login
    {
        Acceso acceso = new Acceso();

        public int Login(string usuario, string contrasenia)
        {
            int fa = 0;
            
            SqlParameter[] parametros = new SqlParameter[2]
            {
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Contrasenia", contrasenia)
            };

            return acceso.Escribir("ValidarUsuario", parametros);
        }

    }
}
