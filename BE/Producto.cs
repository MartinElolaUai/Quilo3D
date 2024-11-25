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
        private double tiempoImpresion;
        private double peso;
        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double TiempoImpresion
        {
            get { return tiempoImpresion; }
            set { tiempoImpresion = value; }
        }


        public int IdImpresora
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
