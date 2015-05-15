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
        private string conexion;
        public EmpleadoCAD()
        {
            conexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\TrueDriveBD.mdf';Integrated Security=True";
        }

        //Método para insertar un empleado en la BD
        //devuelve un tipo bool dependiendo de si ha podido insertar
        public bool InsertarEmpleado(EmpleadoEN nE)
        {
            bool insert = false;

            string cmd = "Insert into Empleado values('" + nE.Dni + "','" + nE.Nombre + "','" + nE.Apellidos + "','" + nE.Direccion + "','" + nE.NumContacto + "','" + nE.Email + "','" + nE.Usuario + "','" + nE.Pass + "')";

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
            }
            return insert;
        }

        //Método para borrar un empleado de la BD
        //devuelve un tipo bool dependiendo de si ha podido insertar
        public bool BorrarEmpleado(string dni)
        {
            bool delete = false;

            string cmd = "delete from empleado where dni = '" + dni + "'";

            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                c.ExecuteNonQuery();
                delete = true;
            }
            catch (Exception e)
            {
                delete = false;
            }
            finally
            {
                con.Close();
            }
            return delete;
        }

        //Método que saca toda la información de un empleado asociada a un dni
        //devuelve verdadero y la informacion si se ha encontrado
        public EmpleadoEN SacarEmpleado(string dni)
        {
            string cmd = "select * from empleado where dni = '" + dni + "'";

            SqlConnection con = new SqlConnection(conexion);
            EmpleadoEN emp = new EmpleadoEN();
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                SqlDataReader dr = c.ExecuteReader();
                dr.Read();

                emp = new EmpleadoEN((string)dr[0], (string)dr[1], (string)dr[2],
                    (string)dr[3], (int)dr[4], (string)dr[5], (string)dr[6], (string)dr[7]);
                dr.Close();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Close();
            }

            return emp;
        }

        //Método que actualiza la información de un empleado en la BD
        public bool ActualizarEmpleado(EmpleadoEN empleado)
        {
            bool update = false;

            string cmd = "update empleado set nombre = '" + empleado.Nombre + "', apellidos = '" + empleado.Apellidos + "', direccion = '" + empleado.Direccion + "', numContacto = " + empleado.NumContacto + ", email = '" + empleado.Email + "', usuario = '" + empleado.Usuario + "', pass = '" + empleado.Pass + "' where dni = '" + empleado.Dni + "'";

            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                c.ExecuteNonQuery();
                update = true;
            }
            catch (Exception e)
            {
                update = false;
            }
            finally
            {
                con.Close();
            }
            return update;
        }

        public bool ConsultarEmpleado(string usuario, string pass)
        {
            bool consult = false;
            string comando = "SELECT usuario,pass FROM Empleado WHERE usuario ='" + usuario + "' AND pass ='" + pass + "'";
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read() == true)
                    consult = true;
                else
                    consult = false;
                
            }
            catch (Exception e)
            {
                consult = false;
            }

            con.Close();
            return consult;
        }
    }
}
