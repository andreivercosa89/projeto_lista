using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Joaquina");
            lista.Add("Raimunda");

            Console.Write(lista.Count);

            Console.WriteLine("Informe mais um valor par a lista");
            lista.Add(Console.ReadLine());

            Console.WriteLine("Informe o nome para de elimindo lista");
            lista.Remove(Console.ReadLine());


            foreach (var e in lista){
                Console.WriteLine("Lista: " + e);
            }

            Console.Write(lista.Count);

        }
    }
}
