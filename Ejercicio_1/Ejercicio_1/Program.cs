namespace Ejercicio_1
{
    internal class Program
    {
        public static string invertirCifras(string palabra) {
            char[] palabra_invertida =  {'0'};
            uint contador = 0; 

            for (int i = palabra.Length; i > 0; i--)
            {
                palabra_invertida[contador] = palabra[i];
                contador++;
            }
            return Convert.ToString(palabra_invertida);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero a invertir: ");
            String input = Console.ReadLine();

            Console.WriteLine($"{invertirCifras(input)}");
            
            
        }
    }
}
