using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        private int idVenta;
        private int idCliente;
        private int idProducto;
        private DateTime fechaVenta;
        private double valor;
        private string descripcion;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public double Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        public DateTime FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

    }
}
