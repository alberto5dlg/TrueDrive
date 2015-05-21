using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.CAD;

namespace LibreriaTD.EN
{
    public class BonificacionesEN
    {
        private int idBonificacion;
        private string descripcion;
        private decimal cantidadBonificacion;
        private string franja;

         public BonificacionesEN()
        {
            this.idBonificacion = -1;
            this.descripcion = null;
            this.cantidadBonificacion = -1;
            this.franja = null;
        }

         public BonificacionesEN(int idBonificacion, string descripcion, decimal cantidadBonificacion, string franja)
        {
            this.idBonificacion = idBonificacion;
            this.cantidadBonificacion = cantidadBonificacion;
            this.descripcion = descripcion;
            this.franja = franja;
        }

        //Getters y Setters
         public int IdBonificacion
        {
            get { return idBonificacion; }
            set { idBonificacion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal CantidadBonificacion
        {
            get { return cantidadBonificacion; }
            set { cantidadBonificacion = value; }
        }

        public string Franja
        {
            get { return franja; }
            set { franja = value; }
        }

        public BonificacionesEN[] MostrarBonificaciones()
        {
            BonificacionesCAD nemple = new BonificacionesCAD();
            return nemple.MostrarBonificaciones();
        }
    }
}
