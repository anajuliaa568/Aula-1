using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "eu to morrendo da fome, porque eu nao almocei o suficiente";
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem : {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("da", "1")
                .Replace("fome", "2").Replace("eu", "3");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem : {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("1", "da")
                .Replace("2", "fome").Replace("3", "eu");


            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem : {primeiroTexto.Length} caracteres.");

            Console.ReadKey();
        }
    }
}
