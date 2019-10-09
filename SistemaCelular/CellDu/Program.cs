using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    class Program
    {
        //1- Colocar console app para startar o projeto
        //2- Adicionar referencia CatalogoCelulares
        //3- Adicionar Entity em nosso projeto
        //4- Adicionar using ao nosso projeto Model,Controller
       static  CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimosuma opção de menu inicial
            var opcao = int.MinValue;
            //Definimos que enquanto for diferente de 0 ele continua em nosso loop
            while(opcao != 0)
            {
                //Apresentação do menu inicial
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1- Inserir Celular");
                Console.WriteLine("0 - Sair");

                //Obtemos o menu escolhido pela usuario
                //opcao = int.Parse(Console.ReadLine());

                //Switch nos ajuda com a escolha da opção
                 switch (opcao)
                {
                //Caso for opção 1 ele insere o celular
                    case 1:
                        InserirCelular();
                        break;
                    default: // Caso colocar uma opção não válida
                        break;
                }
                //Colocamos true para informar que nao deve aparecer na tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        //Inserir
        public static void InserirCelular()
            //Apresentamos a tela em que estamos
        {
            Console.WriteLine("-- Inserir Celular --");
            Console.WriteLine("Informe o Marca do Celular");
            
            //Obtemos a marca do usuario
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");

            //Obtemos o modelo do aparelho
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");
             
            //Obtemos o valor do aparelho
            var preco = double.Parse(Console.ReadLine());

            //Criamos o resultado para identificar sucesso ou erro
            var resultado = celulares.  //Nossa controler pelo nme
                inserirCelular(new Celular()
                {
                    Marca = marca,
                    Modelo = modelo,
                    Preco = preco

                }) ; 

             //Verificamos se o resultado é verdadeiro ou falso
             if (resultado) //Caso verdade sucesso
                Console.WriteLine("Celular cadastrado com sucesso!");
             else  //Caso False apresenta o aviso
                Console.WriteLine("Erro ao cadastrar o aparelho :( ");

        }

        //Atualizar
        //Remover
        //Listar
    }
}
