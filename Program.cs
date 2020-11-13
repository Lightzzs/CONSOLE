using System;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro Numero: ");
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.Write("Digite o Segundo Numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            // Console.Write("O Resultado é: ");
           // Console.WriteLine(soma);

            Console.WriteLine("O Resultado de " + num1 + "+" + num2 + " é: " + soma);
        }
    }
}
