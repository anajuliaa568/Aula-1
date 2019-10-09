using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCervejas
{
   public class Program
    {
        static void Main(string[] args)
        {
            var minhaLista = new List<String>();

            minhaLista.Add("Corona");
            minhaLista.Add("Budweiser");
            minhaLista.Add("Brahma");
            minhaLista.Add("Antarctica");


            minhaLista.ForEach(item => Console.WriteLine(item));


            Console.ReadKey();
        }
    }
    }

