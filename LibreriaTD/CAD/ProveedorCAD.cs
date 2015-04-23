using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.EN;
using System.Data;

namespace LibreriaTD.CAD
{
    public class ProveedorCAD
    {
        //private string conexion;

        public ProveedorCAD()
        {
           // conexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BDDPAA2011.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        }

        //Crear empleado.
        public int crearProveedor(ProveedorEN proveedorNuevo)
        {
            int idEmpleado = 0;
            /*SqlConnection con = null;

            string comando = "Insert into Empleado (Nif,nombre,apellidos,usuario,password,direccion,ciudad,pais,codigoPostal,email,telefono,foto,sueldo,cuentaBancaria) values ('" + empleadoNuevo.Nif + "' , '" + empleadoNuevo.Nombre + "' , '" + empleadoNuevo.Apellidos + "' , 'c" + empleadoNuevo.Usuario + "' , '" + empleadoNuevo.Password + "' , '" + empleadoNuevo.Direccion + "' , '" + empleadoNuevo.Ciudad + "' , '" + empleadoNuevo.Pais + "' , '" + empleadoNuevo.CodigoPostal + "' , '" + empleadoNuevo.Email + "' , '" + empleadoNuevo.Telefono + "' , '" + empleadoNuevo.Foto + "' , '" + empleadoNuevo.Sueldo + "' , '" + empleadoNuevo.CuentaBancaria + "')";

            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                idEmpleado = cmd.ExecuteNonQuery();
                return idEmpleado;
            }

            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (con != null)
                    con.Close();
            }*/
            return idEmpleado;
        }

        //Borrar proveedor.
        public int bajaProveedor(ProveedorEN borrarProveedor)
        {
            
            int idEmpleado = 0;
            /*
            SqlConnection con = null;

            string comando = "Delete from Empleado where Nif ='" + borrarEmpleado.Nif + "' and nombre='" + borrarEmpleado.Nombre + "' and apellidos='" + borrarEmpleado.Apellidos + "' and usuario='" + borrarEmpleado.Usuario + "'";

            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                idEmpleado = cmd.ExecuteNonQuery();
                return idEmpleado;
            }

            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (con != null)
                    con.Close();
                MessageBox.Show("Empleado Borrado Correctamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
            return idEmpleado;
        }

        //Modificar proveedor.
        public int modifcarProveedor(ProveedorEN prove)
        {
            
            int idEmple = 0;
            /*SqlConnection con = null;

            string comando = "update Empleado set nif=' " + prove.Nif + "', usuario =' " + prove.Usuario + "', password =' " + prove.Password + "', nombre =' " + prove.Nombre + "', apellidos =' " + prove.Apellidos + "', ciudad =' " + prove.Ciudad + "', telefono =' " + prove.Telefono + "', direccion =' " + prove.Direccion + "', codigoPostal =' " + prove.CodigoPostal + "', cuenta =' " + prove.Cuenta + "', pais =' " + prove.Pais + "', email =' " + prove.Email + "', sueldo =' " + prove.Sueldo + "'";
            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                idEmple = cmd.ExecuteNonQuery();
                return idEmple;
            }

            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (con != null)
                    con.Close();
            }*/
            return idEmple;
        }

        //Buscar Proveedor por su Cif.
        public DataSet buscarPorCif(string c)
        {
            /*
            SqlConnection con = null;

            string comando = "select Nif, nombre, apellidos, telefono, ciudad from Empleado where Nif like '%" + c + "%'";

            try
            {
                con = new SqlConnection(conexion);

                //crear un bd virtual para meter los datos en ella
                DataSet bdporNif = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(comando, con);

                //metemos los datos en el data
                da.Fill(bdporNif, "empleado");

                return bdporNif;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }*/
            return null;
        }

        //Buscar Proveedor por su Ciudad.
        public DataSet buscarPorCiudad(string c)
        {
            /*
            SqlConnection con = null;

            string comando = "select Nif, nombre, apellidos, telefono, ciudad, sueldo from Empleado where ciudad like '%" + c + "%'";

            try
            {
                con = new SqlConnection(conexion);

                //crear un bd virtual para meter los datos en ella
                DataSet bdporCiudad = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(comando, con);

                //metemos los datos en el data
                da.Fill(bdporCiudad, "empleado");

                return bdporCiudad;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }*/
            return null;
        }

        //Proveedores en un comboBox (Funcion para que alguien que haga otra EN y CAD pueda visualizar proveedores).
        public DataSet visualizarProveedor()
        {
            /*
            SqlConnection con = null;

            string comando = "select Nombre from Empleado";

            try
            {
                con = new SqlConnection(conexion);

                //crear un bd virtual para meter los datos en ella
                DataSet bdcat = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(comando, con);

                //metemos los datos en el data
                da.Fill(bdcat, "empleado");

                return bdcat;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }*/
            return null;
        }

        public DataSet listaPaises()
        {
            /*
            SqlConnection con = null;

            string comando = "select nombre from Pais";

            try
            {
                con = new SqlConnection(conexion);

                //crear un bd virtual para meter los datos en ella
                DataSet bdprovCod = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(comando, con);

                //metemos los datos en el data
                da.Fill(bdprovCod, "Pais");

                return bdprovCod;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }*/
            return null;

        }

    }
}
