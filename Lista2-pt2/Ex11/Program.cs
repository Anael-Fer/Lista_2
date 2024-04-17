using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char vogal;

            Console.WriteLine("Selecione uma opção:");
            vogal = char.Parse(Console.ReadLine());

            switch (vogal) 
            { 
                case 'a':
                    Console.WriteLine("Vogal");
                    break;
                case 'e':
                    Console.WriteLine("Vogal");
                    break;
                case 'i':
                    Console.WriteLine("Vogal");
                    break;
                case 'o':
                    Console.WriteLine("Vogal");
                    break;
                case 'u':
                    Console.WriteLine("Vogal");
                    break;
                default:
                    Console.WriteLine("Consoante");
                    break;
            }

            Console.ReadLine();
        }
    }
}
