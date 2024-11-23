﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Impresora
    {
        private int idImpresora;
        private int idMaterial;
        private int consumoElectrico;
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int ConsumoElectrico
        {
            get { return consumoElectrico; }
            set { consumoElectrico = value; }
        }

        public int IdMaterial
        {
            get { return idMaterial; }
            set { idMaterial = value; }
        }

        public int IdImpresora  
        {
            get { return idImpresora; }
            set { idImpresora = value; }
        }

    }
}
