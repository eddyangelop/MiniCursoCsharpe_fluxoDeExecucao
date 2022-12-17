using System;

namespace IfESwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int mes;

            Console.WriteLine("Qual a sua Idade?");
            idade = int.Parse(Console.ReadLine());

            if(idade < 18) {
                Console.WriteLine("Você é menor de idade!");
            }
            else {
            Console.WriteLine("Você é maior de idade!");
            }

            Console.WriteLine("Qual o mes do seu aniversario?");
            mes = int.Parse(Console.ReadLine());

            switch(mes) {
                case 1:
                Console.WriteLine("Janeiro");
                break;
            
                case 2:
                Console.WriteLine("Fevereiro");
                break;

                case 3:
                Console.WriteLine("Março");
                break;

                case 4:
                Console.WriteLine("Abril");
                break;

                case 5:
                Console.WriteLine("Maio>");
                break;

                case 6:
                Console.WriteLine("Junho");
                break;

                case 7:
                Console.WriteLine("Julho");
                break;

                case 8:
                Console.WriteLine("Agosto");
                break;

                case 9:
                Console.WriteLine("Setembro");
                break;

                case 10:
                Console.WriteLine("Outubro");
                break;

                case 11:
                Console.WriteLine("Novembro");
                break;

                case 12:
                Console.WriteLine("Dezembro");
                break;

                case <= 0:
                Console.WriteLine("Numero Invalido!");
                break;

                case > 12:
                Console.WriteLine("Numero Invalido!");
                break;

            }

        }
            
    }
}