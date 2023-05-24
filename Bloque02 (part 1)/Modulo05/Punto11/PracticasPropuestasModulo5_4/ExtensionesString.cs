using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticasPropuestasModulo5_4
{
    public static class ExtensionesString
    {

        public static bool EstaVacia(this string texto)
        {
            if (texto == null) return true;

            return false;

        }
        public static string Invertir(this string texto)
        {
            if (texto == null) return null;

            char[] charArray = texto.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Left(this string texto, int endIndex)
        {
            if (texto == null) return null;

            return texto.Substring(0, endIndex);
        }

        public static string Right(this string texto, int startIndex)
        {
            if (texto == null) return null;

            return texto.Substring(texto.Length - startIndex);
        }
    }
}