using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[2];

            arrayLinear[0] = "Ana";
            arrayLinear[1] = "Julia";

            List<string> listaLinear = new List<string>
            {
                "Ana",
                "Julia"
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(arrayLinear[0]);
            var keypress = Console.ReadKey().KeyChar.ToString();

        }
    }
}
