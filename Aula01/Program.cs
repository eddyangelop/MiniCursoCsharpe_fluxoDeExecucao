using System;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int total;

            System.Console.WriteLine("Digite o primeiro valor:");
            valor1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Valor1 digitado é: " + valor1);
            

            System.Console.WriteLine("Digite o segundo valor:");
            valor2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Valor2 digitado é: " + valor2);

            total = valor1 + valor2;
            System.Console.WriteLine("A soma dos dois valores é: " + total);
            
        }
    }
}