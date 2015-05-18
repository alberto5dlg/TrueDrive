using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LibreriaTD.EN
{
    public class ValidacionesEN
    {
        public ValidacionesEN()
        {
        }

        //ver si un campo pasado por parametro esta vacio o no
        public bool Vacio(string campo)
        {
            if (campo.Length == 0)
                return true;    
            return false;
        }

        //Expresion regular para un campo con cinco digitos ( valido para docigoProducto o codigoPostal... )
        public bool codigo5Digitos(string cod)
        {
            string patron = @"^\d{6}$";

            if (Regex.Match(cod, patron).Success)
                return true;
            else
                return false;
        }

        //Expresion regular para campos de numero solo enteros ( cantidad... )
        public bool numeroEntero(string num)
        {
            string patron = @"[^0-9]";

            if (Regex.Match(num, patron).Success)
                return true;
            else
                return false;
        }

        //Expresion regular para campos de numero solo decimales ( precio... )
        public bool numeroDecimal(string num)
        {
            string patron = @"^[0-9]{1,5}(\.[0-9]{0,2})?$";

            if (Regex.Match(num, patron).Success)
                return true;
            else
                return false;
        }

        //Validar NIF
        public bool ValidarNif(string campo)
        {
            string patron = @"^\d{8}[a-zA-Z]{1}";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }

        //Validar Email
        public bool ValidarEmail(string campo)
        {

            string patron = @"^[a-zA-Z0-9_-]{2,}[@][a-zA-Z0-9_-]{2,}[.]{1}[a-zA-Z]{2,4}";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }

        //Validar CodigoPostal
        public bool ValidarCP(string campo)
        {
            string patron = @"^\d{5}";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }

        //Validar Telefono
        public bool ValidarTelefono(string campo)
        {
            string patron = @"^9\d{8}";
            string patron2 = @"^6\d{8}";
            if (Regex.Match(campo, patron).Success || Regex.Match(campo, patron2).Success)
                return false;
            return true;
        }

        //Validar Password
        public bool ValidarPassword(string campo)
        {
            string patron = @"[0-9a-zA-Z]+";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }

        //Validar NombrePersona
        public bool ValidarNombrePersona(string campo)
        {
            string patron = @"[a-zA-Z]+";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }

        //Validar ApellidosPersona
        public bool ValidarApellidosPersona(string campo)
        {
            string patron = @"[a-zA-Z]+";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }

        //Validar CiudadPersona
        public bool ValidarCiudadPersona(string campo)
        {
            string patron = @"[a-zA-Z]+";
            if (Regex.Match(campo, patron).Success)
                return false;
            return true;
        }
    }
}
