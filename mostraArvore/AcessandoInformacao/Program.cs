using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuSistema();

        }
        private static void MenuSistema()
        {
            Console.WriteLine("ESCOLHA UMA DAS OPÇÕES DE MENU:");
            Console.WriteLine("1 - Calculo de Área.");
            Console.WriteLine("2 - Mostrar Animação.");
            Console.WriteLine("3 - Mostrar Lista Carros.");
            Console.WriteLine("4 - Sair do Sistema.");


            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                     break;

                case 2:
                    {
                        arvore.ExecutarAnimacao();
                        MenuSistema();
                    }
                    break;
                case 3:
                    {
                        var listaDeCarros = new MostrarListasCarros();
                        listaDeCarros.MostraListaCarros();
                        MenuSistema();
                    }
                    break;
                    case 4:
                    {
                      
                        Console.WriteLine("Saindo...");
                        return;
                    }
                    break;

                default:
                    break;
            }
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();


            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadKey();


        }
    }
}
