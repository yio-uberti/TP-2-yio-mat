using System.Timers;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int Nro1, Nro2 ;

            Console.WriteLine("Ingrese un valor para el num 1:");
            Nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para el num 2:");
            Nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion a realizar: \n");
            Console.WriteLine("1) SUMA \n2) RESTA \n3) DIVISION " +
                "\n4) PRODUCTO \n5) FACTORIAL \n6) RESIDUO \n7) CONVERTIR A BINARIO");

            Console.WriteLine("\nSu opcion: ");
            entrada = Console.ReadLine();

            switch (entrada) 
            {
                case "1":
                    Console.WriteLine($"La suma es: {Nro1 + Nro2}");
                    break;
                case "2":
                    Console.WriteLine($"La resta es: {Nro1 + Nro2}");
                    break;
                case "3":
                    if (Nro2 != 0)
                    {
                        Console.WriteLine($"La division es: {Nro1 / Nro2}");
                    }
                    else {
                        Console.WriteLine("no se puede ejecutar la division");
                    }
                    break;
                case "4":
                    Console.WriteLine($"El producto es: {Nro1 * Nro2}");
                    break;
                case "5":
                    int facNro1 = factorial(Nro1);
                    int facNro2 = factorial(Nro2);
                    Console.WriteLine($"El factorial del Nro1 es: {facNro1}");
                    Console.WriteLine($"El factorial del Nro2 es: {facNro2}");
                    break;
                case "6":
                    int residuo = Nro1 % Nro2;
                    Console.WriteLine($"El residuo es: {residuo}");
                    break;
                case "7":
                    //No se como hacerlo y para que no me retes usando ChatGpt hacelo vos
                    break;
            }   
        }
        static int factorial(int num) {

            int i = 1,ope = 1;
            do
            {
                ope *= i;
                i++;
            } while (i <= num);

            return ope;
        }
    }
}
