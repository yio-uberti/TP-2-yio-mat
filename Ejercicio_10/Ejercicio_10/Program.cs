using System.Security.AccessControl;

namespace Ejercicio_10
{
    internal class Program
    {
        // Funciones
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }

        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
        static void Main(string[] args)
        {
            byte k = 0;

            Console.WriteLine("Ingrese la palabra: ");
            string SuNombre = Console.ReadLine();

            // Salidas
            Console.WriteLine("La longitud de la palabra es de: " + SuNombre.Length);
            Console.WriteLine($"La palabra {SuNombre} " + (SuNombre.Contains("Mateo") ? "Contiene la palabra Mateo" : "NO contiene la palabra Mateo"));
            Console.WriteLine($"Reemplazando a la vocal \" A \" por la letra \" B \"  {SuNombre.Replace("a", "b")}");
            Console.WriteLine($"En minusculas: {SuNombre.ToLower()}");
            Console.WriteLine($"En mayusculas: {SuNombre.ToUpper()}");
            Console.WriteLine($"Eliminando las 3 primeras letras: {SuNombre.Remove(0, 3)}");
            Console.WriteLine($"Solo las 3 primeras letras: {SuNombre.Substring(0, 3)}");

            // Recorrer Arreglar funcion
            for (k = 0; k < SuNombre.Length+1; k++)
            {
                Console.WriteLine(Left(SuNombre, k));
            }

            for (k = 0; k < SuNombre.Length+1; k++)
            {
                Console.WriteLine(Right(SuNombre, k));
            }
        }
    }
}
