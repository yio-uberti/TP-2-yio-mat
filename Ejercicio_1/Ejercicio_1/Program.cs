namespace Ejercicio_1
{
    internal class Program
    {
        public static int invertirCifras(string palabra) {
            
            int resultado = 0, numero;
            numero = int.Parse(palabra);

            for (int i = 0; i < palabra.Length; i++)
            {
                //Asigno el último dígito
                resultado += numero % 10;
                
                //Descarto el último dígito
                numero /= 10;
    
                //Corro la cifra de lugar hacia la izquiera
                resultado *= 10;
            }

            return resultado/10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero a invertir: ");
            String input = Console.ReadLine();
            Console.WriteLine($"{invertirCifras(input)}");
            
            
        }
    }
}
