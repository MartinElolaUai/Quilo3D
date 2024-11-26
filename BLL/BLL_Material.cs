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

        public int ModificarMaterial(Material material)
        {
            return mapper.ModificarMaterial(material);
        }

        public List<Material> ListarMateriales() 
        {
            return mapper.ListarMateriales();
        }

        public List<Material> ListarMateriales(string tipoMaterial)
        {
            return mapper.ListarMateriales(tipoMaterial);
        }

        public double CalcularCosto(string material, double pesoEnKilos)
        {
            Dictionary<string, double> costosMateriales = new Dictionary<string, double>()
            {
            { "PLA", 20000 },
            { "PLA+", 25000 },
            { "PETG", 30000 },
            { "ABS", 33000 },
            { "PLA FLEX", 23500 }
            };

            double costoPorKilo = costosMateriales[material];

            return costoPorKilo * pesoEnKilos;
        }

        public int CalcularIdMaterial()
        {
            List<Material> materiales = ListarMateriales();
            int id = 0;

            foreach (Material material in materiales)
            {
                if (material.IdMaterial > id)
                    id = material.IdMaterial;
            }

            return id + 1;
        }

        public void ExportarXml()
        {
            mapper.ExportarXml();
        }

        public void ExportarXml(string tipoMaterial)
        {
            mapper.ExportarXml(tipoMaterial);
        }

    }

}
