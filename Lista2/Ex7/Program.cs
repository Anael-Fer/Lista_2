using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Escreva um número:");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 & num % 5 == 0)
                Console.WriteLine("ESeu número é divisivel por 3 e 5");
            else
                Console.WriteLine("ESeu número não é divisivel por 3 e 5");
            Console.ReadLine();
        }
    }
}
