namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base, Altura, Resultado;
            //string linea; En este ejercicio no me hizo falta aplicarlo 

            // Entrada de datos
            Console.WriteLine("Ingrese la base del triangulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            Altura = double.Parse(Console.ReadLine());

            // Hipotenusa se almacena en "Resultado"
            Resultado = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));

            // Salida de datos
            Console.WriteLine(String.Format("Hipotenusa = {0:####.00}", Resultado));
            Console.WriteLine(String.Format("Area = {0:####.00}", ((Base*Altura)/2)));
        }
    }
}
