using System;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ano;

            Console.WriteLine("Digite um ano:");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Ano: ");

            Console.WriteLine((ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0)) ? "é bissexto" : "não é bissexto");

            Console.ReadLine();
        }
    }
}
