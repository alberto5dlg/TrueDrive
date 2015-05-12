using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;


namespace LibreriaTD.CAD
{
    class EmpleadoCAD
    {
        private string conexion = @"data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TrueDriveDB.mdf;User Instance=true";
        public EmpleadoCAD()
        {
            conexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TrueDriveDB.mdf;User Instance=true"; 
        }

        //Método para insertar un empleado en la BD
        //devuelve un tipo bool dependiendo de si ha podido insertar
        public bool InsertarEmpleado(EmpleadoEN nE)
        {
            bool insert = false ;

            Console.WriteLine(nE.Nombre);
            string cmd = "Insert into Empleado values('" + nE.Dni + "','" + nE.Nombre + "','" + nE.Apellidos + "','" + nE.Direccion + "','" + nE.NumContacto + "','" + nE.Email + "','" + nE.Usuario + "','" + nE.Usuario + "','" + nE.Pass + "')";

            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                c.ExecuteNonQuery();
                insert = true;
            }
            catch (Exception e)
            {
                insert = false;
            }
            finally
            {
                con.Close();
                insert = true;
            }
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
