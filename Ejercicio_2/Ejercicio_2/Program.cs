using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_2
{
    internal class Program
    {
        static bool primo(int num) {
            if (num <= 1)
            {
                return false;
            }

            // Cualquier numero Entero puede ser divisible por 1 y por si mismo, a excepcion del 0
            for(uint i = 2; i < (num-1); i++){
                //Si encuentra algún numero que puede ser dividido por otro numero rompe el ciclo
                if ((num%i)==0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (primo(input))
            {
                Console.WriteLine($"El numero \"{input}\" ES numero primo");
            }
            else
            {
                Console.WriteLine($"El numero \"{input}\" NO es numero primo");
            }

        }
    }
}
