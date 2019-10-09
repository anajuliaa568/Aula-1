using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeCarro.Model;

namespace AtividadeCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            var atividadeCarro = new List<carro>();
            Console.WriteLine("                              INÍCIO DO CADASTRO DO VEÍCULO");
            atividadeCarro.Add(new carro());
            Console.WriteLine("Digite a marca do seu veículo, por gentiliza:");
            var marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo do seu veículo?");
            var modelo = Console.ReadLine();
            Console.WriteLine("Informe o ano do seu veículo");
            var ano = Console.ReadLine();
            Console.WriteLine("Qual o valor do seu veículo?");
            var valor = Console.ReadLine();
            Console.WriteLine("Perfeito!! Cadastro feito com sucesso.");
            var listaVeiculo = new List<Carro>


            {
                new Carro
                {
                    Marca = marca,
                    Modelo = modelo,
                    Ano = ano,
                    Valor = valor

                }
            };


            listaVeiculo.ForEach(
                i => Console.WriteLine(
                $"Marca: {i.Marca}, " +
                $"Modelo:{i.Modelo}, " +
                $"Ano:{i.Ano}, " +
                $"Valor:{i.Valor}"));

            Console.ReadLine();
            {

            }






        }

    }
}

    
    

