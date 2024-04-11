namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte CantidadNro;
            int Nro;
            string entrada;
            Random ran = new Random();

            Console.WriteLine("Ingrese el limite para los num aleatorios(menor a 256): ");
            entrada = Console.ReadLine();
            CantidadNro = Convert.ToByte(entrada);

            for (int i = 0; i < CantidadNro; i++) {

                Nro = ran.Next(100);

                Console.WriteLine($"El numero ramdon es: {Nro} ");
                string caracter = Convert.ToString((char)Nro);
                Console.WriteLine($"El número aleatorio es: {Nro}, su caracter ASCII es: {caracter}");

            }
            Console.ReadKey();
        }
    }
}
