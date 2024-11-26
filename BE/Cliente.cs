using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return  nombre; }
            set {  nombre = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string ApellidoDni
        {
            get { return $"{Apellido} - {Dni}"; }
        }

    }
}
