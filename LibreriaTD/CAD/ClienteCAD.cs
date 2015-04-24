using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.EN;
using System.Data;

namespace LibreriaTD.CAD
{
    class ClienteCAD
    {
        //private string conexion;
        
        public ClienteCAD()
        {
        }

        public bool InsertarCliente(ClienteEN newCliente)
        {
            bool insert = false;
            return insert;
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
    }
}
