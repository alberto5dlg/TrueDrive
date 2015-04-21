using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTD.EN
{
    class PedidoEN
    {
        //Campos
        private int codPedido;
        private string fechaEnvio;
        private string fechaEntrega;
        private string proveedor;
        private string producto;
        private int cantidad;
        private string direccionEnvio;
        private string direccionEntrega;
        private string numContacto;
        private string email;
        private float precio;
        private string infoAdicional;

        //Constructor

        public PedidoEN(int codPedido, string fechaEnvio, string fechaEntrega, string proveedor, string producto, int cantidad, string direccionEnvio, string direccionEntrega, string numContacto, string email, float precio, string infoAdicional)
        {
            this.codPedido = codPedido;
            this.fechaEnvio = fechaEnvio;
            this.fechaEntrega = fechaEntrega;
            this.proveedor = proveedor;
            this.producto = producto;
            this.cantidad = cantidad;
            this.direccionEnvio = direccionEnvio;
            this.direccionEntrega = direccionEntrega;
            this.numContacto = numContacto;
            this.precio = precio;
            this.infoAdicional = infoAdicional;
        }

        //Getters & Setters

        public int CodPedido
        {
            get { return codPedido; }
            set { codPedido = value; }
        }

        public string FechaEnvio
        {
            get { return FechaEnvio; }
            set { fechaEnvio = value; }
        }
        public string FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string DireccionEnvio
        {
            get { return direccionEnvio; }
            set { direccionEnvio = value; }
        }
        public string DireccionEntrega
        {
            get { return direccionEntrega; }
            set { direccionEntrega = value; }
        }
        public string NumContacto
        {
            get { return numContacto; }
            set { numContacto = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string InfoAdicional
        {
            get { return infoAdicional; }
            set { infoAdicional = value; }
        }
    }
}
