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
        private double precio;
        private int puertas;
        private string motor;
        private double km;
        private int anyo;
        private string tipo;
        private int plazas;
        private string cambio;
        private string color;
        private string matricula;
        private string imagen;

        public CocheEN()
        {
            this.marca = null;
            this.modelo = null;
            this.precio = -1;
            this.puertas = -1;
            this.motor = null;
            this.km = -1;
            this.anyo = -1;
            this.tipo = null;
            this.plazas = -1;
            this.cambio = null;
            this.color = null;
            this.matricula = null;
            this.imagen = null;
        }

        public CocheEN(string matricula, string marca, string modelo, double precio, int puertas, string motor,
            double km, int anyo, string tipo, int plazas, string cambio, string color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.puertas = puertas;
            this.motor = motor;
            this.km = km;
            this.anyo = anyo;
            this.tipo = tipo;
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

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
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
            set { puertas = value; }
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

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
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


        //Cuando adquiramos un nuevo coche en nuestro catalogo lo insertaremos en la base de datos
        public bool InsertarCoche()
        {
            bool insert = false;
            CocheCAD cocheCad = new CocheCAD();
            insert = cocheCad.InsertarCoche(this);
            return insert;
        }
        //se borrara un coche por completo cuando no queden mas unidades en stock
        public void BorrarCoche()
        {
            bool borra = false;
            CocheCAD cocheCad = new CocheCAD();
            borra = cocheCad.BorrarCoche(this.matricula);
        }
        //Actualiza los datos en la BD
        public bool Actualizar()
        {
            bool update = false;
            CocheCAD cocheCad = new CocheCAD();
            update = cocheCad.Actualizar(this);
            return update;
        }

        //Sacamos información de la BD a partir de una matrícula e insertamos los datos en el objeto
        public bool SacarCoche(string matricula)
        {
            bool exito = false;
            CocheCAD cocheCad = new CocheCAD();
            CocheEN coche = cocheCad.SacarCoche(matricula);
            this.marca = coche.marca;
            this.modelo = coche.modelo;
            this.precio = coche.precio;
            this.puertas = coche.puertas;
            this.motor = coche.motor;
            this.km = coche.km;
            this.anyo = coche.anyo;
            this.tipo = coche.tipo;
            this.plazas = coche.plazas;
            this.cambio = coche.cambio;
            this.color = coche.color;
            this.matricula = coche.matricula;
            return exito;
        }
    }
}