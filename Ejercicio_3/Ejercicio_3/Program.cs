namespace Ejercicio_3
{
    internal class Program
    {
        public static bool Armstrong(int num) {
            int longitud = num.ToString().Length, copia = num;
            int[] aux = new int[longitud];
            
            //Dividimos los digitos del numero
            for(uint i = 0; copia > 0; i++)
            {
                aux[i] = copia % 10;
                copia /= 10;
            }

            int[] sum = new int[2];
            sum[1] = 1;
            //Verificamos si es Armstrong
            for (uint i = 0; i < longitud; i++) {
                if (aux[i] != 0)
                {

                    for (uint j = 0; j < longitud; j++)
                    {
                        //Se "eleva" cada numero, en sum[1] se almacenan todas las multiplicaciones
                        sum[1] *= aux[i];
                    }
                    //Suma total, en sum[0] se almacena la suma total
                    sum[0] += sum[1];
                    //Se resetea la variable
                    sum[1] = 1;
                }
            }

            return num == sum[0];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero a verificar: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Armstrong(input) ? $"El numero {input} es Armstrong" : $"El numero {input} NO es Armstrong");
        }
    }
}
