using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.CAD;

namespace LibreriaTD.EN
{
    //Entidad correspondiente a un coche
    public class CocheEN
    {
        //Variables privadas que definen los atributos del coche. 
        private string marca;
        private string modelo;
        private float precio;
        private int puertas;
        private string motor;
        private float km;
        private int anyo;
        private string combustible;
        private int plazas;
        private string cambio;
        private string color;
        private int unidades;

        // Getters y  Setters basicos para el funcionamiento de la entidad
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Puertas
        {
            get { return puertas; }
            set {puertas = value; }
        }

        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        public float Km
        {
            get { return km; }
            set { km = value; }
        }

        public int Anyo
        {
            get { return anyo; }
            set { anyo = value; }
        }

        public string Combustible
        {
            get { return combustible; }
            set { combustible = value; }
        }

        public int Plazas
        {
            get { return plazas; }
            set { plazas = value; }
        }

        public string Cambio
        {
            get { return cambio; }
            set { cambio = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
        //Cuando adquiramos un nuevo coche en nuestro catalogo lo insertaremos en la base de datos
        public void insertarCoche()
        {
            bool insert = false;
            CocheCAD cocheCad = new CocheCAD();
            insert = cocheCad.InsertarCoche(this);
            if (!insert) //en caso de que no se pueda insertar el coche pq ya esta en la base de datos
            {            //modificaremos las unidades 
                this.Unidades = unidades + 1;
                cocheCad.modUds(this.unidades);
            }
        }
        //se borrara un coche por completo cuando no queden mas unidades en stock
        public void borrarCoche()
        {
            bool borra = false;
            CocheCAD cocheCad = new CocheCAD();
            borra = cocheCad.BorrarCoche(this);
            if (borra == false) // en caso de que no se pueda borrar se llamara a otra funcion 
            {                   //para modificar las unidades
                this.Unidades = unidades - 1; //decremento las unidades disponibles
                cocheCad.modUds(this.unidades);
            }
        }

        public void modKM()
        {
            //se modificaran cuando el coche sea alquilado y tenga mas km. 
            CocheCAD cocheCad = new CocheCAD();
            cocheCad.modKM(km);
        }
        //En caso de subida o bajada de precio del vehiculo, tendremos que modificar su precio 
        public void modPrecio()
        {
            CocheCAD cocheCad = new CocheCAD();
            cocheCad.modPrecio(precio);
        }

        
    }
}