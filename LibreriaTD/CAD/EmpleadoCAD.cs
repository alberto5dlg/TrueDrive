using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;

namespace LibreriaTD.CAD
{
    class EmpleadoCAD
    {
        string conexion;//Variable que se usará para guardar la cadena de conexión con la BD

        public EmpleadoCAD()
        {
            //Aquí se adquirirá la cadena de conexión
        }

        //Método para insertar un empleado en la BD
        //devuelve un tipo bool dependiendo de si ha podido insertar
        public bool InsertarEmpleado(EmpleadoEN newEmpleado)
        {
            bool insert = false;
            return insert;
        }

        //Método para borrar un empleado de la BD
        //devuelve un tipo bool dependiendo de si ha podido insertar
        public bool BorrarEmpleado(string dni)
        {
            bool insert = false;
            return insert;
        }

        //Método que modifica la dirección de un empleado y actualiza la BD
        //devuelve un tipo bool dependiendo de si ha podido actualizar
        public bool ModDireccion(string dni, string nuevaDireccion)
        {
            bool insert = false;
            return insert;
        }

        //Método que modifica el email de un empleado y actualiza la BD
        //devuelve un tipo bool dependiendo de si ha podido actualizar
        public bool ModEmail(string dni, string nuevoEmail)
        {
            bool insert = false;
            return insert;
        }

        //Método que modifica el nombre de usuario de un empleado y actualiza la BD
        //devuelve un tipo bool dependiendo de si ha podido actualizar
        public bool ModUsuario(string dni, string nuevoUsuario)
        {
            bool insert = false;
            return insert;
        }

        //Método que modifica la contraseña de un empleado y actualiza la BD
        //devuelve un tipo bool dependiendo de si ha podido actualizar
        public bool ModPass(string dni, string nuevaPass)
        {
            bool insert = false;
            return insert;
        }

        //Método que saca toda la información de un empleado asociada a un dni
        //devuelve verdadero y la informacion si se ha encontrado
        public bool SacarEmpleado(string dni)
        {
            bool encontrado = false;

            return encontrado;
        }

        //Método que actualiza la información de un empleado en la BD
        public void ActualizarEmpleado(EmpleadoEN empleado)
        {

        }
    }
}
