using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.CAD;
using LibreriaTD.EN;

namespace LibreriaTD.EN
{
    public class ClienteEN
    {
        private string nif;
        private string nombre;
        private string apellidos;
        private string email;
        private string direccion;
        private string ciudad;
        private string pais;
        private string telefono;
        private string interesadoEn;
        private string fechaNacimiento;

        public ClienteEN(string nif, string nombre, string apellidos, string email, string direccion,
            string ciudad, string pais, string telefono, string interesadoEn, string fechaNac)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.pais = pais;
            this.telefono = telefono;
            this.interesadoEn = interesadoEn;
            this.fechaNacimiento = fechaNac;
        }

        public string nifCliente
        {
            get { return nif; }
            set { nif = value; }
        }

        public string nombreCliente
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string apellidosCliente
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string emailCliente
        {
            get { return email; }
            set { email = value; }
        }

        public string direccionCliente
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string ciudadCliente
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string paisCliente
        {
            get { return pais; }
            set { pais = value; }
        }

        public string telefonoCliente
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string interesadoEnCliente
        {
            get { return interesadoEn; }
            set { interesadoEn = value; }
        }

        public string anyoNacimientoCliente
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public void InsertarCliente()
        {
            ClienteCAD nuevoCliente = new ClienteCAD();
            nuevoCliente.InsertarCliente(this);
        }

        public void BorrarCliente()
        {
            ClienteCAD delCliente = new ClienteCAD();
            delCliente.BorrarCliente(this);
        }

        public void modDireccion(string newDirecc,string newCiudad)
        {
            ClienteCAD modDir = new ClienteCAD();
            modDir.modDireccion(this.nif, newDirecc, newCiudad);
        }

        public void modTelefono(string newTelf)
        {
            ClienteCAD modTelf = new ClienteCAD();
            modTelf.modTelefono(newTelf);
        }
    }
}