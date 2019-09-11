using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program

    {   //Iniciando uma constante de um numero inteiro
        const int testeConst = 999;
       

        static void Main(string[] args)
        {
            string TestePrimitivo = string.Empty;
            string outroTestePrimitivo = string.Empty;
            bool testComp;
            Boolean testeComp;
            bool? testeBoolNull;

            int numeroInteiro = 999;
            long numeroInteiroLongo = 123456;

            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "String"; //Texto
            var teste2 = 'C'; //Char
            var teste3 = 8; //Int
            var teste4 = 3.8; //Double
            var teste5 = 0x0F; //Hex
            //Apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
    }
}
