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
        private double IVA = 1.21;
        private int idFactura;
        private string idCliente;
        private CocheEN[] coches;
        private double precioIva;
        private double precioSinIva;
        private string direccion;
        private string fecEmision;
        private string fecCobro;
        private double descBonif;
        private double precioTotal;
        private int numPedido;

        public FacturacionEN(int idFactura, string idCliente, CocheEN coches, double precioSinIva,
            string direccion, string fecEmision, string fecCobro, double descBonif, int numPedido)
        {
            this.idFactura = idFactura;
            this.idCliente = idCliente;
            this.coches[0] = coches; // Esto tengo dudas de como se hace realmente
            this.precioSinIva = precioSinIva;
            this.direccion = direccion;
            this.fecEmision = fecEmision;
            this.fecCobro = fecCobro;
            this.descBonif = descBonif;
            this.numPedido = numPedido;
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

        public double PrecioIva
        {
            get { return ( this.PrecioSinIva * IVA); }
            set { precioIva = value; }
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

        public double DescBonif
        {
            get { return descBonif; }
            set { descBonif = value; }
        }

        public double PrecioTotal
        {
            get{return (this.PrecioIva - this.DescBonif);}
        }

        public int NumPedido
        {
            get { return numPedido; }
            set { numPedido = value; }
        }

       
    }
}
