using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule a média aritmética entre 3 números reais digitados pelo usuário.
            Console.WriteLine("Média Aritmética de 3 números\n");

            Console.Write("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            float num3 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Média: {(num1+num2+num3)/3}");
        }
    }
}
