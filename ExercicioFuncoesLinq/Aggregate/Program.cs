using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
        {
                "Ana",
                "Karine",
                "Tamara",
                "Junior",
                "Bruno",
                "Cristiane"
        };

            var texto = listaDeNomes.Aggregate((nome1, nome2) => nome1 + ";\r\n" + nome2);
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
