using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.WriteLine("Digite uma idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 & idade <= 7)
                Console.WriteLine("Sua categoria: Infantil A");
            else if (idade >= 8 & idade <= 10)
                Console.WriteLine("Sua categoria: Infantil B");
            else if (idade >= 11 & idade <= 13)
                Console.WriteLine("Sua categoria: Juvenil A");
            else if (idade >= 14 & idade <= 17)
                Console.WriteLine("Sua categoria: Juvenil B");
            else
                Console.WriteLine("Sua categoria: Sênior");
            Console.ReadLine();
        }
    }
}
