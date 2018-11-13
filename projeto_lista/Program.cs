using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto="";
            int qtdant;
            List<string> lista = new List<string>();


            do
            {
                Console.Write("Informe o nome a ser add: ");
                lista.Add(Console.ReadLine().Trim());

                Console.Write("Digite Sair ou der enter par continuar : ");
                texto = Console.ReadLine();
                Console.Clear();

            } while (texto != "sair");

            qtdant = lista.Count();

                Console.Write("Informe o nome a ser eliminado: ");
                lista.Remove(Console.ReadLine());

            Console.Clear();
            foreach(var l in lista){
                Console.Write(" " + l);
            }

            Console.WriteLine("\nHaviam {0} numeros agora ha {1}", qtdant, lista.Count);


        }
    }
}
