using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Digite um número de 0 a 5:");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
                Console.WriteLine("Número escrito por extenso: Zero");
            else if (num == 1)
                Console.WriteLine("Número escrito por extenso: Um");
            else if (num == 2)
                Console.WriteLine("Número escrito por extenso: Dois");
            else if (num == 3)
                Console.WriteLine("Número escrito por extenso: Tres");
            else if (num == 4)
                Console.WriteLine("Número escrito por extenso: Quatro");
            else if (num == 5)
                Console.WriteLine("Número escrito por extenso: Cinco");
            else 
                Console.WriteLine("Valor inválido");
            Console.ReadLine();
        }
    }
}
