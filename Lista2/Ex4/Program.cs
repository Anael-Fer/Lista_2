using System;
using static System.Net.Mime.MediaTypeNames;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcoes;
            double num1, num2, resultado;

            Console.WriteLine("Selecione uma opção:");
            opcoes = int.Parse(Console.ReadLine());

            if (opcoes == 1)
            {
                Console.WriteLine("Digite um número para somar:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número para somar:");
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 + num2;

                Console.WriteLine("Soma dos dois números: " +  resultado);
            }
            else if (opcoes == 2)
            {
                Console.WriteLine("Digite um número para subtrair:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número para subtrair:");
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 - num2;

                Console.WriteLine("Subtração dos dois números: " + resultado);
            }
            else if (opcoes == 3)
            {
                Console.WriteLine("Digite um número para multiplicar:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número para multiplicar:");
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 * num2;

                Console.WriteLine("Multiplicação dos dois números: " + resultado);
            }
            else if (opcoes == 4)
            {
                Console.WriteLine("Digite um número para a divisão:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número a divisão:");
                num2 = double.Parse(Console.ReadLine());

                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Erro");
                }
                else if(num1 != 0 || num2 != 0)
                {
                 resultado = num1 / num2;
                 Console.WriteLine("Divisão dos dois números: " + resultado);
                }
            }
            else
            { 
                Console.WriteLine("Número errado"); 
            }
            Console.ReadLine();
        }
    }
}
