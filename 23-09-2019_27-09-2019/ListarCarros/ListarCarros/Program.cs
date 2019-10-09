using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarCarros
{
    public class Program
    {
        static void Main(string[] args)
        {
            var minhaLista = new List<String>();

            minhaLista.Add("Toyota");
            minhaLista.Add("Nissan");
            minhaLista.Add("Hyundai");
            minhaLista.Add("Volkswagen");
            minhaLista.Add("Ford");
            minhaLista.Add("Honda");
            minhaLista.Add("Chevrolet");
            minhaLista.Add("Kia");


            minhaLista.ForEach(item => Console.WriteLine(item));


            Console.ReadKey();
        }
    }
    }

