using System;
using System.Linq;

namespace projeto_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];
            nomes[0] = "Andrei";
            nomes[1] = "Sofia";
            nomes[2] = "Darcy";

            var listaNomes = nomes.ToList();
            listaNomes.Remove("Darcy");

            foreach(string el in listaNomes)
            {
                Console.WriteLine("Nome: " + el);
            }

        }
    }
}
