using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using LibreriaTD.CAD;
using LibreriaTD.EN;

namespace LibreriaTD.EN
{
    class FacturacionEN
    {
        private int idFactura;
        private string idCliente;
        private CocheEN[] coches;
        private double precioSinIva;
        private string direccion;
        private string fecEmision;
        private string fecCobro;
        private int numPedido;

        public FacturacionEN(int idFactura, string idCliente, CocheEN[] coches, double precioSinIva,
            string direccion, string fecEmision, string fecCobro, int numPedido)
        {
            this.idFactura = idFactura;
            this.idCliente = idCliente;
            this.coches = coches; 
            this.precioSinIva = precioSinIva;
            this.direccion = direccion;
            this.fecEmision = fecEmision;
            this.fecCobro = fecCobro;
            this.numPedido = numPedido;
        }

        public CocheEN[] Coches
        {
            get { return coches; }
            set { coches = value; }
        }

        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }

        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public double PrecioSinIva
        {
            get { return precioSinIva; }
            set { precioSinIva = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string FecEmision
        {
            get { return fecEmision; }
            set { fecEmision = value; }
        }

        public string FecCobro
        {
            get { return fecCobro; }
            set { fecCobro = value; }
        }

        public int NumPedido
        {
            get { return numPedido; }
            set { numPedido = value; }
        }

       
    }
}
