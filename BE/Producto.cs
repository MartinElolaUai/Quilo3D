using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int idProducto;
        private int idMaterial;
        private int idImpresora;
        private decimal tiempoImpresion;
        private decimal peso;

        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public decimal TiempoImpresion
        {
            get { return tiempoImpresion; }
            set { tiempoImpresion = value; }
        }


        public int MyProperty
        {
            get { return idImpresora; }
            set { idImpresora = value; }
        }


        public int IdMaterial
        {
            get { return idMaterial; }
            set { idMaterial = value; }
        }


        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

    }
}
