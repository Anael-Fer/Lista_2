using System;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num_extenso;


            Console.WriteLine("Escreva um número:");
            num_extenso = int.Parse(Console.ReadLine());

            switch (num_extenso)
            {
                case 0:
                    Console.WriteLine("Zero");
                   break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                default:
                    {
                        Console.WriteLine("Número inválido!");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
