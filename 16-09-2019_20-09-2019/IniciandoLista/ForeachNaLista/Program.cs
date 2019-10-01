using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {

        static void main(string[] args)

            
        {

            var minhaLista = new List<String>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");


            minhaLista.ForEach(item => Console.WriteLine(item));


            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()

        {
            var minhalista = new List<DateTime>();
            minhalista.Add(new DateTime(2019, 9, 17));
            minhalista.Add(new DateTime(2019, 9, 18));
            minhalista.Add(new DateTime(2019, 9, 19));
            minhalista.Add(new DateTime(2019, 9, 20).AddDays(99));

            minhalista.ForEach(minhaData => Console.WriteLine(minhaData));

            Console.ReadKey();



        }


        private static void ListaDeInteiros()
        {
            var minhalista = new List<int>();

            minhalista.Add(17);
            minhalista.Add(18);
            minhalista.Add(19);
            minhalista.Add(20);

            minhalista.ForEach(meuNumero => Console.WriteLine(meuNumero.ToString("C",CultureInfo.CurrentCulture)));

            Console.ReadKey();
        }
        /// <summary>
        /// minha lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(FormataNumeroDecimalEmBitCoin(meuDecimal)));
        }

        private static string FormataNumeroDecimalEmBitCoin(double meuNumero)
        {
            return (meuNumero / 41997.32).ToString("N6", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
                
        }

       
    } }
