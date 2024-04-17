using System;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            double numero, conversao;

            Console.WriteLine("Selecione uma opção:");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) 
            {
                case 1:
                    Console.WriteLine("Escreva um número:");
                    numero = double.Parse(Console.ReadLine());

                    conversao = numero * 100.0;
                    Console.WriteLine("Conversão de centímetros para metros: " + conversao + "metro(s)");
                    break;

                case 2:
                    Console.WriteLine("Escreva um número:");
                    numero = double.Parse(Console.ReadLine());

                    conversao = numero / 100.0;
                    Console.WriteLine("Conversão de metros para centímetros: " + conversao + "centímetro(s)");
                    break;

                case 3:
                    Console.WriteLine("Escreva um número:");
                    numero = double.Parse(Console.ReadLine());

                    conversao = numero * 1000.0;
                    Console.WriteLine("Conversão de milímetros para metros: " + conversao + "centímetro(s)");
                    break;

                case 4:
                    Console.WriteLine("Escreva um número:");
                    numero = double.Parse(Console.ReadLine());

                    conversao = numero / 1000.0;
                    Console.WriteLine("Converter de metros para milímetros: " + conversao + "centímetro(s)");
                    break;

                    default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
