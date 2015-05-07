using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTD.EN
{
    class MarcaEN
    {
        private int idMarca;
        private string nombre;
        private int anyo;
        private string descripcion;
        private string fundador;
        private string sede;
        private string filial;

	   
	     public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public int Anyo
        {
            get { return anyo; }
            set { anyo = value; }
        }
       
         public string Descripcion
	    {
	    	get { return descripcion;}
	    	set { descripcion = value;}
	    }

         public string Fundador
         {
             get { return fundador; }
             set { fundador = value; }
         }

         public string Sede
         {
             get { return sede; }
             set { sede = value; }
         }

         public string Filial
         {
             get { return filial; }
             set { filial = value; }
         }
    }
}
