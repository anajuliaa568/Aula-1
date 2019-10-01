using AtividadeCadastroDePessoasComListagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCadastroDePessoasComListagem
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var cadastroDePEssoas = new List<Pessoa>();
                Console.WriteLine("                                                INÍCIO DO CADASTRO");
                cadastroDePEssoas.Add(new Pessoa());
                Console.WriteLine("Por Favor,informe seu nome completo:");
                var Nome = (Console.ReadLine());
                Console.WriteLine("Qual é a sua idade?");
                var idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o seu sexo?");
                var sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Qual a sua altura?");
                var altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Cadastro realizado com sucesso!!");
                Console.ReadKey();
                var listaDePEssoas = new List<Pessoa>();

                {
                    new Pessoa
                    {
                        Nome = Nome,
                        Idade = idade,
                        Sexo = sexo,
                        Altura = altura

                    
                    };

                listaDePEssoas.ForEach(
                i => Console.WriteLine(
                $"Nome: {i.Nome}, " +
                $"Idade:{i.Idade}, " +
                $"Sexo:{i.Sexo}, " +
                $"Altura:{i.Altura}"));

                Console.ReadLine();
                {

                }

            }






            }
        }
    } 
