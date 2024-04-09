namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            string entrada;

            Console.WriteLine("Ingrese un valor:");
            entrada = Console.ReadLine();

            Console.WriteLine("\n");

            if (entrada.Length != 1)
            {
                Console.WriteLine("No es UNA letra, vuelva a ingresar");
            }

            letra = entrada[0];

            if (char.IsDigit(letra))
            {
                Console.WriteLine("Es una cifra numerica");
            }
            else if (Vocal(letra))
            {
                Console.WriteLine("Es una vocal");
            }
            else if (char.IsLetter(letra)) {
                Console.WriteLine("Es una consonante");
            }

        }

        static Boolean Vocal(char l) {

            if ((l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')) { 
                return true;
            }

            return false;
        }

    }
}
