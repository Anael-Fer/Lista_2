using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade, catC, catB;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite há quanto tempo Você está habilitado na Categoria B (caso não estiver, digite 0):");
            catB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite há quanto tempo Você está habilitado na Categoria C (caso não estiver, digite 0):");
            catC = int.Parse(Console.ReadLine());

            if (idade >= 21 & catB >= 2 || catC >=1)
                Console.WriteLine("Você tem permissão para tirar sua carteira do tipo D");
            else if (idade < 21)
                Console.WriteLine("Permissão negada, pois o usuário não tem a idade necessária");
            else if (catB <2)
                Console.WriteLine("Permissão negada, pois o usuário não os anos necessários em um dos tipos de habilitação");
            else if (catC <1)
                Console.WriteLine("Permissão negada, pois o usuário não os anos necessários em um dos tipos de habilitação");
            Console.ReadLine();
        }
    }
}
