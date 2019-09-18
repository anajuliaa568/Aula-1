using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<CestaDeFrutas>();

            minhaCestaDeFrutas.Add(new CestaDeFrutas()
            {
                Nome = "Uva",
                Quantidade = 5

            });

            {
                Nome = "Melancia",
                Quantidade = 2

            });

            minhaCestaDeFrutas.ForEach(i =>
            Console.WriteLine($"Banana melancia"));

            Console.ReadKey();
        }
    }
    }

