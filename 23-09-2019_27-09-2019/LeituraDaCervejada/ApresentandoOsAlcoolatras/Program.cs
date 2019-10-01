using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Controller;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.ListarInformacoes().
                ForEach(x => Console.WriteLine($"{x.Id} {x.Nome} {x.Litros} {x.Valor} {x.Alcool}"));

            Console.ReadKey();
        }
    
    }
}
