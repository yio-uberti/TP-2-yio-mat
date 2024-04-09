
using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = " ";
            int Nro1, Nro2; 
            

            Console.WriteLine("Ingrese un valor para el num 1:");
            Nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para el num 2:");
            Nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion a realizar: \n");
            Console.WriteLine("1) SUMA \n2) RESTA \n3) DIVISION " +
                "\n4) PRODUCTO \n5) FACTORIAL \n6) RESIDUO \n7) CONVERTIR A BINARIO" +
                "\n8) RAIZ CUADRADA \n9) POTENCIA \n10) COSENO \n11) SENO \n12) VALOR ABSOLUTO" +
                "\n13) REDONDEO \n14) NRO MAXIMO");

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
                    else
                    {
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
                    Console.WriteLine($"El Nro1 en binario es: {Convert.ToString(Nro1, 2)}");
                    Console.WriteLine($"El Nro2 en binario es: {Convert.ToString(Nro2, 2)}");
                    break;
                case "8":
                        Console.WriteLine($"La raiz cuadrada del Nro1 es: {Math.Sqrt(Nro1)}");
                        Console.WriteLine($"La raiz cuadrada del Nro2 es: {Math.Sqrt(Nro2)}");
                    break;
                case "9":
                        Console.WriteLine($"El Nro1 elevado a al Nro2 es: {Math.Pow(Nro1, Nro2)}");
                        Console.WriteLine($"El Nro2 elevado a al Nro1 es: {Math.Pow(Nro2, Nro1)}");
                    break;
                case "10":
                        Console.WriteLine($"El coseno del Nro1 es: {coseno(Nro1)}");
                        Console.WriteLine($"El coseno del Nro2 es: {coseno(Nro2)}");
                    break;
                case "11":
                        Console.WriteLine($"El seno del Nro1 es: {seno(Nro1)}");
                        Console.WriteLine($"El seno del Nro2 es: {seno(Nro2)}");
                    break;
                case "12":
                        Console.WriteLine($"Valor absoluto del Nro1: {Math.Abs(Nro1)}");
                        Console.WriteLine($"Valor absoluto del Nro2: {Math.Abs(Nro2)}");
                    break;
                case "13":
                        decimal nro1 = Nro1;
                        decimal nro2 = Nro2;
                        Console.WriteLine($"Redondeo del Nro1: {Math.Round(nro1)}");
                        Console.WriteLine($"Redondeo del Nro1: {Math.Round(nro2)}");
                    break;
                case "14":
                        Console.WriteLine($"Valor maximo es: {Math.Max(Nro1, Nro2)}");
                    break;
            }
        }
        static int factorial(int num)
        {

            int i = 1, ope = 1;
            do
            {
                ope *= i;
                i++;
            } while (i <= num);

            return ope;
        }
        static double coseno(int num) {

            double result = num;
            result = result * Math.PI / 180.0;
            result = Math.Cos(result);

            return result;
        }

        static double seno(int num) {

            double result = num;
            result = result * (Math.PI / 180.0);
            result = Math.Sin(result);

            return result; 
        }

    }
}
