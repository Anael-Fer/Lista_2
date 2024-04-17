using System;
using static System.Net.Mime.MediaTypeNames;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double w, x, y, z, resultado;

            Console.WriteLine("Digite o valor de W (1 a 4):");
            w = int.Parse(Console.ReadLine());

            if (w == 1)
            {
                Console.WriteLine("Digite o valor de X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y:");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Z:");
                z = int.Parse(Console.ReadLine());

                resultado = Math.Sqrt(x*y*z);

                Console.WriteLine("Resultado do calculo: " + resultado);
            }
            else if (w == 2)
            {

                Console.WriteLine("Digite o valor de X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y:");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Z:");
                z = int.Parse(Console.ReadLine());

                resultado = (x + 2 * y + 3 * z) / 6;

                Console.WriteLine("Resultado do calculo: " + resultado);
            }
            else if (w == 3)
            {

                Console.WriteLine("Digite o valor de X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y:");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Z:");
                z = int.Parse(Console.ReadLine());

                resultado = 1 / (1/x + 1/y + 1/z);

                Console.WriteLine("Resultado do calculo: " + resultado);
            }
            else if (w == 4)
            {

                Console.WriteLine("Digite o valor de X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y:");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Z:");
                z = int.Parse(Console.ReadLine());

                resultado = (x + y + z) / 3;

                Console.WriteLine("Resultado do calculo: " + resultado);
            }
        }
    }
}
