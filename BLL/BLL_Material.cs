using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Material
    {
        MP_Material mapper = new MP_Material();

        public int AltaMaterial(Material material) 
        {
            return mapper.AltaMaterial(material);
        }

        public int BajaMaterial(Material material)
        {
            return mapper.BajaMaterial(material);
        }

        public List<Material> ListarMateriales() 
        {
            return mapper.ListarMateriales();
        }
    
    }

}
