using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

namespace LibreriaTD.CAD
{
    class ClienteCAD
    {
        private string conexion = @"data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TrueDriveDB.mdf;User Instance=true";
        public ClienteCAD()
        {
            conexion = @"data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TrueDriveDB.mdf;User Instance=true";
        }

        public bool InsertarCliente(ClienteEN newCliente)
        {
            
            string comando = "Insert into Cliente (nif,nombre,apellido,email,direccion,ciudad,pais,telefono,interesadoEn,codigopostal,fechaNacimiento,usuario,contraseña,provincia) values ('"+ newCliente.nifCliente+"','"+newCliente.nombreCliente+"',"+newCliente.apellidosCliente+ "','" + newCliente.emailCliente + "','" + newCliente.direccionCliente+"','"+newCliente.ciudadCliente+"','"+newCliente.paisCliente+"','"+newCliente.telefonoCliente+"','"+newCliente.interesadoEnCliente+"','"+newCliente.codpCliente+"','"+newCliente.anyoNacimientoCliente+"','"+newCliente.usuCliente+"','"+newCliente.passCliente+"','"+newCliente.provCliente+"')";
            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException excep)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool BorrarCliente(ClienteEN borCliente)
        {
            bool delete = false;
            return delete;
        }

        public bool modDireccion(string dni, string direccion,string ciudad)
        {
            bool modify = false;
            return modify;
        }

        public bool modTelefono(string telefono)
        {
            bool modify = false;
            return modify;
        }

        public bool ConsultarUsuario(string usuario, string pass)
        {
            bool consult = false;
            string comando = "SELECT * FROM Usuarios WHERE Usuario = "+usuario+" AND Contrasena = " + pass ;

            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.ExecuteNonQuery();

            if (cmd.ExecuteNonQuery() == 1)
                consult = true;
            else
                consult = false;

            con.Close();
            return consult;
        }
    }
}
