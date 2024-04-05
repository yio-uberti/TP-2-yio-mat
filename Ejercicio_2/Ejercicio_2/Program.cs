using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_2
{
    internal class Program
    {
        static bool primo(int num) {
            
            if (num <= 1)
                return false;
            if(num <= 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0)
                return false;
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
            
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int input = int.Parse(Console.ReadLine()); //leer
            Console.WriteLine();
            if (primo(input))
            {
                Console.WriteLine("Es numero primo");
            }
            else
            {
                Console.WriteLine("No es numero primo");
            }

        }
    }
}
