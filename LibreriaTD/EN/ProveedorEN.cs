using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.CAD;

namespace LibreriaTD.EN
{
    public class ProveedorEN
    {
        private string empresa;
        private string cif;
        private string ciudad;
        private int codigoPostal;
        private string pais;
        private string email;
        private int telefono;
        private int fax;


        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Cif
        {
            get { return cif; }
            set { cif = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }


        //Metodos para realizar algunos procedimientos con proveedores.

        public int insertarProveedor()
        {
            /*ProveedorCAD proveedorCad = new ProveedorCAD();
            proveedorCad.CrearProveedor(this);*/
        }

        public int bajaProveedor()
        {
            /*ProveedorCAD proveedorCad = new ProveedorCAD();
            proveedorCad.BajaProveedor(this);*/
        }

        public int modificarProveedor()
        {
            /*
            ProveedorCAD proveedorCAD = new ProveedorCAD();
            proveedorCAD.modifcarProveedor(this);*/
        }

        public DataSet buscarPorCif(string cif)
        {
            /*
            DataSet pNif = new DataSet();
            ProveedorCAD porNif = new ProveedorCAD();
            pNif = porNif.BuscarPorNif(nif);

            return pNif;*/
        }

        public DataSet buscarPorCiudad(string ciudad)
        {
            /*
            DataSet pCiudad = new DataSet();
            ProveedorCAD porCiudad = new ProveedorCAD();
            pCiudad = porCiudad.BuscarPorCiudad(ciudad);

            return pCiudad;*/
        }

        //Mostrar en un combobox los proveedores.
        public DataSet visualizarProveedor()
        {
            /*
            DataSet cat = new DataSet();
            ProveedorCAD paisCad = new ProveedorCAD();

            cat = paisCad.VisualizarProveedor();

            return cat;*/
        }

        public ENProveedor verDatosProveedor(string cf)
        {
            /*
            ENProveedor enproveedor = new ENProveedor();
            ENProveedor proveedor = new ENProveedor();
            DataSet dataprov = new DataSet();

            dataprov = proveedor.buscarProveedor2(cf);

            try
            {
                DataRow datos = dataprov.Tables[0].Rows[0];

                proveedor.empresa = datos["Empresa"];
                proveedor.cif = datos["Cif"].ToString();
                proveedor.ciudad = datos["Ciudad"];
                proveedor.codigoPostal = Convert.ToInt32(datos["codigoPostal"]);
                proveedor.pais = Convert.ToInt32(datos["pais"].ToString());
                proveedor.email = datos["email"].ToString();
                proveedor.telefono = Convert.ToInt32(datos["telefono"]);
                proveedor.fax = Convert.ToInt32(datos["fax"]);
            }
            catch
            {
                MessageBox.Show("No hay nada seleccionado");
            }
            return proveedor;*/
        }

        public DataSet listaPaises()
        {
            /*
            ProveedorCAD pcad = new ProveedorCAD();
            DataSet data = new DataSet();

            data = pcad.ListaPaises();
            return data;*/
        }
    }
}