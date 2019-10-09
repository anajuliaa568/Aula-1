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
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimosuma opção de menu inicial
            var opcao = int.MinValue;
            //Definimos que enquanto for diferente de 0 ele continua em nosso loop
            while (opcao != 0)
            {
                //Apresentação do menu inicial
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1- Inserir Celular");
                Console.WriteLine("2- Atualizar Celular");
                Console.WriteLine("3- Remover Celular");
                Console.WriteLine("4- Listar Celular");
                Console.WriteLine("0 - Sair");

                //Obtemos o menu escolhido pela usuario
                //opcao = int.Parse(Console.ReadLine());

                //Switch nos ajuda com a escolha da opção
                opcao = Int32.Parse(Console.ReadLine());

                switch (opcao)
                {
                    //Caso for opção 1 ele insere o celular
                    case 1:
                        InserirCelular();
                        break;
                    //Caso for a opção 2 ele atualiza um celular existente
                    case 2:
                        AtualizarCelular();
                        break;
                        //Caso for a opçaõ 3 ele remove o celular informado
                        case 3:
                             RemoverCelular();
                        break;
                    case 4:
                        ListarCelular();
                        break;
                    case 0:
                        //Informamos que estamos saindo do sistema
                        Console.WriteLine("Saindo do sistema...");
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

                });

            //Verificamos se o resultado é verdadeiro ou falso
            if (resultado) //Caso verdade sucesso
                Console.WriteLine("Celular cadastrado com sucesso!");
            else  //Caso False apresenta o aviso
                Console.WriteLine("Erro ao cadastrar o aparelho :( ");

        }

        //Atualizar
        public static void AtualizarCelular()
           
        {
            //Apresentamos a tela em que estamos

            Console.WriteLine("-- Atualizar Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()  //Obtemos a lista de celulares
                .ToList<Celular>()  //convertemos para uma lista em memoria
                .ForEach(x =>   //Laço de repetição para mostrar cada celular mostrar no console nosso celular
                Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));

            //Informamos ao usuario que ele precisa colocar o id para realizar a alteração
            Console.WriteLine("Informe i Id para alteração de registro:");
            //Obtemos o id informado
            var celularId = int.Parse(Console.ReadLine());

            //Obtemos do banco o item completo que vamos utilizar

            var celular = celulares  //Banco de dados
                .GetCelulares()  //Obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId); //Regra para obter o celular

            //Verificamos se o celular existe
            if (celular == null)
            {
                //Informe que esse id não encontrou um registro
                Console.WriteLine("Id informado inválido");
                return;
            }
            Console.WriteLine("Informe o Marca do Celular");

            //Obtemos a marca do usuario
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");

            //Obtemos o modelo do aparelho
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do aparelho");

            //Obtemos o valor do aparelho
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares.  //Nossa controller
                AtualizarCelular(celular); //Método que atualiza o celular

            //Parte final que mostramos o resultado do processo de atualização

            if (resultado)
                Console.WriteLine("Celular atualizado com suceso!");
            else
                Console.WriteLine("Erro ao atualizar aparelho");

        }

        public static void ListarCelular()
        {
            Console.WriteLine("--Listar Celular--");

            //Listamos aqui para identificar o item que camos alterar
            celulares.GetCelulares() //Obtemos a lista de celilares
                .ToList<Celular>() // Convertemos para uma lista em memoria
                .ForEach(x => //Laço de repetição para mostrar cada celular
                //Mostramos no console nosso celular
                 Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));
        }

        public static void RemoverCelular()
        {
            Console.WriteLine("--Remover Celular--");

            ListarCelular();

            //Informamos ao usuario que ele precisa que ele precisa colocar o id para realizar a alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            var celularId = int.Parse(Console.ReadLine());

            var resultado = celulares.RemoverCelular(celularId);

            if (resultado)
                Console.WriteLine("Celular removido com sucesso");
            else
                Console.WriteLine("Erro ao remover aparelho.");
        }

    }
}