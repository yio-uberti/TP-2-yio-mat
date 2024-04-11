namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte CantidadH, CantidadP, CantidadB;
            double precioH, precioP, precioB;
            double Resultado;
            string linea;

            CantidadH = CantidadP = CantidadB = 0; 
            precioH = precioP = precioB = Resultado = 0;

            Console.WriteLine("Por favor ingrese la cantidad de hamburguesas o \"-1\"  omitir este producto");
            linea = Console.ReadLine();
            if (linea != "-1")
            {
                CantidadH = Convert.ToByte(linea);
                Console.WriteLine("Por favor ingrese el precio de la hamburguesa");
                linea = Console.ReadLine();
                precioH = Convert.ToDouble(linea);
            }

            Console.WriteLine("Por favor ingrese la cantidad de papas o \"-1\" omitir este paso");
            linea = Console.ReadLine();
            if (linea != "-1")
            {
                CantidadP = Convert.ToByte(linea);
                Console.WriteLine("Por favor ingrese el precio de las papas");
                linea = Console.ReadLine();
                precioP = Convert.ToDouble(linea);
            }
            Console.WriteLine("Por favor ingrese la cantidad de bebidas o \"-1\" omitir este paso");
            linea = Console.ReadLine();
            if (linea != "-1")
            {
                CantidadB = Convert.ToByte(linea);
                Console.WriteLine("Por favor ingrese el precio de las bebidas");
                linea = Console.ReadLine();
                precioB = Convert.ToDouble(linea);
            }

            //Precio total
            Resultado = CantidadH * precioH + CantidadP * precioP + CantidadB * precioB;

            //Parte entera del total
            Console.WriteLine($"La parte entera de la compra es: {(int) (Resultado)}");
            
            //Total de la compra con 2 decimales, con los ceros luego del . puedo controlar cuantos decimales mostrar. 
            //Reemplaza el cero con el dígito correspondiente si hay uno presente; de lo contrario, aparece cero en la cadena de resultado. Reemplaza el símbolo "#" con el dígito correspondiente si hay uno presente; de lo contrario, no aparece ningún dígito en la cadena de resultado.
            Console.WriteLine(String.Format("La compra total es de: {0:####.00}", Resultado));

            //Total de la compra con moneda local, tambien se puede forzar a otro tipo de moneda por ejemplo: 123.456 ("C", ja-JP) -> ¥123 
            Console.WriteLine(String.Format("En pesos: {0:c}", Resultado));

            //Total de la compra en formato general, se puede controlar hasta cuantos digitos quiero mostrar por ejemplo G4 mostraria 4 digitos. Imprime los numeros sin ceros de más
            Console.WriteLine(String.Format("Total: {0:g}", Resultado));

            //Patrón completo de fecha/hora (largo tiempo).
            Console.WriteLine(String.Format("La compra se realizó el: {0:F}", DateTime.Now));

            //Patrón de cita corta "d" (día de la semana + día/mes/año)
            Console.WriteLine(String.Format("Fecha resumida: {0:dddd}{0: dd/MM/yyy}", DateTime.Now));
            Console.ReadKey();

        }
    }
}
