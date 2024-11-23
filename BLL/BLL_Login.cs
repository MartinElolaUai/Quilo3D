using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_Login
    {
        MP_Login mapper = new MP_Login();

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            DataTable resultado = mapper.ValidarUsuario(usuario, contrasena);

            if (resultado.Rows.Count > 0)
            {
                int loginExitoso = Convert.ToInt32(resultado.Rows[0]["LoginExitoso"]);
                return loginExitoso == 1; 
            }

            return false;
        }

    }
}
