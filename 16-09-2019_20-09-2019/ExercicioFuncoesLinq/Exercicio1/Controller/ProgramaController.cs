﻿using Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Controller
{
    public class ProgramaController
    {
        public static List<Carros> listaCarro { get; set; } = new List<Carros>();

        public static void StartApp()
        {
            do
            {
                Console.Clear();
                CarrosController.ReadExcel();
                ShowInfos(listaCarro);
                ShowMenu();
            } while (TryAgain());
        }

        private static bool TryAgain()
        {
            Console.WriteLine("Gostaria de tentar novamente? (1 para sim)");
            return Console.ReadKey().KeyChar.ToString() == "1";
        }

        private static void ShowInfos(List<Carros> lista)
        {
            var format = "ID: {0,-3} Nome: {1,-35} Valor: {2,-5} Quantidade: {3,-2} Data: {4,-10}";
            lista.ForEach(i => Console.WriteLine(String.Format(format, i.Id, i.Nome, i.Valor.ToString("C3"), i.Quantidade, i.Data.ToShortDateString())));
        }

        private static void ShowMenu()
        {
            bool flag = true;
            int mes = 0;
            while (flag)
            {
                Console.Write("Digite o mês numérico que você quer tirar relátorio: ");
                Int32.TryParse(Console.ReadLine(), out mes);
                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Digite corretamente o mês!");
                }
                else
                {
                    flag = false;
                }
            }
            Console.Clear();
            ShowSellsPerMonth(mes);
        }

        private static void ShowSellsPerMonth(int mes)
        {
            var mesesVenda = ProgramaController.listaCarro.Where(i => i.Data.Month == mes).ToList();
            ShowInfos(mesesVenda);
            ShowSumPerMonth(mesesVenda);
            ShowAveragePerMonth(mesesVenda);
        }

        private static void ShowSumPerMonth(List<Carros> listaCarros)
        {
            Console.WriteLine($"Valor de vendas total do mês: {(listaCarros.Sum(x => x.Valor).ToString("C3"))}");
        }

        private static void ShowAveragePerMonth(List<Carros> listaCarros)
        {
            Console.WriteLine($"Media de vendas total do mês: {(listaCarros.Average(x => x.Valor).ToString("C3"))}");

        }
    }
}
