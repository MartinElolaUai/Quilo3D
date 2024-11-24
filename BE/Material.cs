using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Material
    {
        private int idMaterial;
        private string color;
        private decimal pesoKg;
        private decimal costo;
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public decimal PesoKg
        {
            get { return pesoKg; }
            set { pesoKg = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int IdMaterial
        {
            get { return idMaterial; }
            set { idMaterial = value; }
        }




    }
}
