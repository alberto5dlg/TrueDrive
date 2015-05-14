using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.CAD;

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
        private string usuario;
        private int codp;
        private string provincia;
        private string contrasenya;

        
        public ClienteEN(string nif, string nombre, string apellidos, string email, string direccion,
            string ciudad, string pais, string telefono, string interesadoEn, string fechaNac,string usuario,
            string provincia,int codp,string contrasenya)
        {
            this.codp = codp;
            this.provincia = provincia;
            this.usuario = usuario;
            this.contrasenya = contrasenya;
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
        public ClienteEN()
        {
            this.codp = 0;
            this.provincia = null;
            this.usuario = null;
            this.contrasenya = null;
            this.nif = null;
            this.nombre = null;
            this.apellidos = null;
            this.email = null;
            this.direccion = null;
            this.ciudad = null;
            this.pais = null;
            this.telefono = null;
            this.interesadoEn = null;
            this.fechaNacimiento = null;
        }
        public int codpCliente
        {
            get { return codp; }
            set { codp = value; }
        }

        public string provCliente
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string usuCliente
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string passCliente
        {
            get { return contrasenya; }
            set { contrasenya = value; }
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

        public bool InsertarCliente()
        {
            bool insert = false;
            ClienteCAD nuevoCliente = new ClienteCAD();
            insert = nuevoCliente.InsertarCliente(this);
            return insert;
        }

        public bool BorrarCliente()
        {
            bool delete = false;
            ClienteCAD delCliente = new ClienteCAD();
            delete = delCliente.BorrarCliente(this.nifCliente);
            return delete;
        }

        public bool ModCliente()
        {
            bool modify = false;
            ClienteCAD cliCad = new ClienteCAD();
            modify = cliCad.ModCliente(this);
            return modify;

        }

        public bool ConsultarUsuario()
        {
            bool consult = false;
            ClienteCAD conUsu = new ClienteCAD();
            consult = conUsu.ConsultarUsuario(this.usuCliente,this.passCliente);
            return consult;
        }

    }
}