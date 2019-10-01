using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarTamanhoNome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informar o nome a ser calculado:");
            var nomelenght = Console.ReadLine();

            Console.WriteLine($"O tamanho deste nome é {nomelenght.Replace(" ","").Length}");
                Console.ReadKey();
        }
    }

}
