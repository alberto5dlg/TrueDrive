using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.CAD;


namespace LibreriaTD.EN
{
    public class EmpleadoEN
    {
        //Atributos de la clase empleado
        private string dni;
        private string nombre;
        private string apellidos;
        private string direccion;
        private int numContacto;
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
            this.numContacto = 0;
            this.email = null;
            this.usuario = null;
            this.pass = null;

        }

        public EmpleadoEN(string dni, string nombre, string apellidos, string direccion, int numContacto, string email, string usuario, string pass)
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
        public int NumContacto
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

        public bool InsertarEmpleado()
        {
            EmpleadoCAD inEmp = new EmpleadoCAD();
            bool insert = false;
            insert = inEmp.InsertarEmpleado(this);
            return insert;
        }

        public void BorrarEmpleado()
        {
            EmpleadoCAD boEmp = new EmpleadoCAD();
            boEmp.BorrarEmpleado(this.dni);
        }
        //Dado un dni copia todo el contenido del empleado en la clase
        public bool ClonarEmpleado(string dni)
        {
            EmpleadoCAD clEmp = new EmpleadoCAD();
            EmpleadoEN empAux = clEmp.SacarEmpleado(dni);
            bool exito = false;
            if (empAux != null)
            {
                this.dni = empAux.dni;
                this.nombre = empAux.nombre;
                this.apellidos = empAux.apellidos;
                this.direccion = empAux.direccion;
                this.numContacto = empAux.numContacto;
                this.email = empAux.email;
                this.usuario = empAux.usuario;
                this.pass = empAux.pass;

                exito = true;
            }

            return exito;
        }
        //Actualiza los valores del empleado en la BD
        public bool Actualizar()
        {
            bool exito;
            EmpleadoCAD acEmp = new EmpleadoCAD();
            exito = acEmp.ActualizarEmpleado(this);
            return exito;
        }
    }
}
