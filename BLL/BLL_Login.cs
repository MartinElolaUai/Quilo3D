using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_Login
    {
        MP_Login mapper = new MP_Login();

        public bool Login(string usuario, string contrasena)
        {
            try
            {
                int resultado = mapper.Login(usuario, contrasena);
                return resultado == 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
        }

    }
}
