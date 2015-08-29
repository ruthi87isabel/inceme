using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTools
{
    /// <summary>
    /// Contiene metodos que implementan comparaciones entre cadenas de caracteres
    /// </summary>
    public static class CustomNameComparison
    {
        /// <summary>
        /// Encuentra similitud entre cadenas de caracteres que se diferencian solo por espacios y acentos
        /// </summary>
        /// <param name="cadena1">cadena a comparar</param>
        /// <param name="cadena2">cadena a comparar</param>
        /// <returns>retorna verdadero si las cadenas se diferencias solamente en espacios y acentos vocales</returns>
        public static bool CadenasSimilares(string cadena1, string cadena2)
        {
            // Cadena de caracteres original a sustituir.
            const string original = "áàäéèëíìïóòöúùuÁÀÄÉÈËÍÌÏÓÒÖÚÙÜ";
            // Cadena de caracteres ASCII que reemplazarán los originales.
            const string ascii = "aaaeeeiiiooouuuAAAEEEIIIOOOUUU";
            string[] array1 = cadena1.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = cadena2.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (array1.Length != array2.Length) return false;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < original.Length; j++ )
                {
                    // Reemplazamos los caracteres especiales.
                    array1[i] = array1[i].Replace(original[j], ascii[j]);
                    array2[i] = array2[i].Replace(original[j], ascii[j]);
                }
                if (array1[i] != array2[i]) return false;
            }
            return true;
        }

    }
}
