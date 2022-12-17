using System;

namespace StructureRepetition
{
    internal class Program
    {

    //foreach    
        static void Main(string[] args)
        {
         int[] lista = {1, 2, 3, 4, 5};

         foreach (int numero in lista)
         {
            Console.WriteLine(numero);
         }


//for        
        //  int valor;
        //  Console.WriteLine("Digite o valor:");
        //  valor = int.Parse(Console.ReadLine());

        //  for (int i = valor; i <= 10; i++) {
        //     Console.WriteLine(i);
        //  }



//dowhile
        //    Boolean condicao = true;  
        //    int valor;

        
        //     do {
        //         Console.WriteLine("Digite um valor, 0 para sair");
        //         valor = int.Parse(Console.ReadLine());

        //         if(valor == 0) {
        //         Console.WriteLine("Você saiu da aplicacão");
        //         condicao = false;
        //         }
        //         else {
        //             Console.WriteLine("O valor informado é: " + valor);
        //         }
        //     }  while (condicao == true);
        }
    }
}