﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class ValidacionesDatos
    {
        public bool ValidarVacio(string valor, string campo)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("el campo " + campo + " se encuentra vacío");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarNumero(string input, ref int valor, string campo)
        {
            bool flag = false;

            if (!int.TryParse(input, out valor))
            {
                Console.WriteLine("Por favor, ingresar un valor numérico en el campo " + campo + ".");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Por favor, ingresar un valor positivo");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
        public bool ValidarFecha(string fecha, ref DateTime salida, string campo)
        {
            bool flag = false;

            if (!DateTime.TryParse(fecha, out salida))
            {
                Console.WriteLine("El dato no es una fecha valida en el campo: " + campo + ".");
            }
            else if (salida <= new DateTime(1910, 01, 01) || salida > DateTime.Today)
            {
                Console.WriteLine("La fecha es inválida en el campo: " + campo + ".");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public bool ValidarTipoNum(ref int valor, string campo)
        {
            bool flag = false;

            if (valor != 1 && valor != 2 && valor != 3)
            {
                Console.WriteLine("Por favor, ingresar un valor válido del " + campo + ".");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarID (string input)
        {
            bool flag = true;
            if(!(input.Length == 36))
            {
                //los tipos de dato GUID tienen 36 caracteres
                Console.WriteLine("El ID debe tener 36 caracteres.");
            }
            else if (FormatoGuid(input) == false)
            {
                Console.WriteLine("El ID contiene dígitos especiales y solo debe contener números");
            }
            else if(Guid.TryParse(input, out Guid idvalidado))
            {
                Console.WriteLine("El ID contiene un formato válido.");
            }
            else
            {
                flag = false;
                Console.WriteLine("El ID no contiene un formato válido");
            }

            return flag;
        }

        public bool FormatoGuid(string input)
        {
            // Patrón regex para validar el formato de Guid con 4 guiones y caracteres alfanuméricos
            string patron = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

           return Regex.IsMatch(input, patron);
        }
    }
}

