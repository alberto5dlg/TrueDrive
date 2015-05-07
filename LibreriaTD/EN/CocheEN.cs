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
        private double precio;//precio del producto sin IVA 
        private int puertas;
        private string motor;
        private double km;
        private int anyo;
        private string combustible;
        private int plazas;
        private string cambio;
        private string color;
        private string matricula;
        private double precioTotal;// Precio del producto total tras aplicar el IVA 

        public CocheEN(string marca, string modelo,double precio,int puertas,string motor,string matricula,
            double km,int anyo,string combustible,int plazas,string cambio,string color,int unidades)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.puertas = puertas;
            this.motor = motor;
            this.km = km;
            this.anyo = anyo;
            this.combustible = combustible;
            this.plazas = plazas; 
            this.cambio = cambio;
            this.color = color;
            this.matricula = matricula;
        }
        // Getters y  Setters basicos para el funcionamiento de la entidad

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

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

        public double Precio
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

        public double Km
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


        public double PrecioTotal
        {
            get { return (this.Precio * 1.21); }
            set { precioTotal = value; }
        }

        //Cuando adquiramos un nuevo coche en nuestro catalogo lo insertaremos en la base de datos
        public void insertarCoche()
        {
            bool insert = false;
            CocheCAD cocheCad = new CocheCAD();
            insert = cocheCad.InsertarCoche(this);
           
        }
        //se borrara un coche por completo cuando no queden mas unidades en stock
        public void borrarCoche()
        {
            bool borra = false;
            CocheCAD cocheCad = new CocheCAD();
            borra = cocheCad.BorrarCoche(this);
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