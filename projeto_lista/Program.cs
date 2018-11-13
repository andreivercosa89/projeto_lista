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
            var nomes="";
            List<string> lista = new List<string>();
            List<string> listaant = new List<string>();



            do
            {
                Console.Write("Informe o nome a ser add: ");
                nomes = Console.ReadLine().Trim().ToUpper();

                if(!lista.Contains(nomes)) lista.Add(nomes);
                else Console.WriteLine("Nome ja informado."); 

                Console.Write("Digite sair ou der enter para continuar : ");
                texto = Console.ReadLine();
                //Console.Clear();

            } while (texto != "sair");

            listaant = lista.ToList();

            Console.Write("Informe o nome a ser eliminado: ");
            lista.Remove(Console.ReadLine().ToUpper());


            Console.Write("Lista antes:\n");
            foreach (var l in listaant) { Console.Write(" " + l); }
            Console.Write("\n\nLista atual:\n");
            foreach (var l in lista) { Console.Write(" " + l); }

        }
    }
}
