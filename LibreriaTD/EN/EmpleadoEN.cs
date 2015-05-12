using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.CAD;


namespace LibreriaTD.EN
{
    class EmpleadoEN
    {
        //Atributos de la clase empleado
        private string dni;
        private string nombre;
        private string apellidos;
        private string direccion;
        private string numContacto; //Esta variable es del tipo string por si se quiere poner el prefijo de país ej: (+34 XXXXXXXXX)
        private string email;
        private string usuario;
        private string pass; //Contraseña

        //Constructor
        public EmpleadoEN()
        {
            this.dni = null;
            this.nombre = null;
            this.apellidos = null;
            this.direccion = null;
            this.numContacto = null;
            this.email = null;
            this.usuario = null;
            this.pass = null;
        }

        public EmpleadoEN(string dni, string nombre, string apellidos, string direccion, string numContacto, string email, string usuario, string pass)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.numContacto = numContacto;
            this.email = email;
            this.usuario = usuario;
            this.pass = pass;
        }

        //Getters / Setters
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
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
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public void InsertarEmpleado()
        {
            EmpleadoCAD inEmp = new EmpleadoCAD();
            inEmp.InsertarEmpleado(this);
        }

        public void BorrarEmpleado()
        {
            EmpleadoCAD boEmp = new EmpleadoCAD();
            boEmp.BorrarEmpleado(this.dni);
        }
    }
}
