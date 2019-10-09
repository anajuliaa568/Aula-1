using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {

        static LivrosController livros = new LivrosController();

        public static object IdContador { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");

            MostraMenuSistema();
        }

        /// <summary>
        /// Mostra no console o menu disponível do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Lista Livro");
            Console.WriteLine("3 -Cadastrar Livro");
            Console.WriteLine("4 - Cadastrar usuario");
            Console.WriteLine("5 - Remover usuario");

            //Aqui vamos egar numero digitado
            //Executar proxima funcao 
            Console.Write("Sua opção: ");
            var situacao = Console.ReadLine();
            switch (situacao)
            {
                case "1":
                    ListarUsuário();
                    break;
                case "2":
                    ListarLivro();
                    MostraMenuSistema();
                    break;
                case "3":
                    AdicionarLivro();
                    break;
                case "5":
                    while (!RealizaLoginSistema())
                        break;
                    break;
                default:
                    break;
            }
        }

        private static void AdicionarUsuario()
        {

            UsuarioController.AdicionarUsuario(new Usuario());

            Console.WriteLine("Cadastrar usuário dentro do sistema!");

            Console.WriteLine("Informe um Login:");
            var loginUsuario = Console.ReadLine();

            Console.WriteLine("Informe uma senha:");
            var senhaUsuario = Console.ReadLine();

            UsuarioController.AdicionarUsuario(new Usuario()
            {
                Id = IdContador
                Login = loginUsuario,
                Senha = senhaUsuario


            });
        }
        
        private static void ListarUsuário()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// MEtodo que adiciona dentro da nossa lista um novo registro de livros
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema");

            //informamos que para dar continuidade ele deve informar im nome para o livro
            Console.WriteLine("Nome do livro para cadastro");
            //Obtemos esta informacao do usuario
            var nomeDoLivro = Console.ReadLine();

            //"livrosController" livros controle e nosso objeto em memória
            //com isso temos disponivel nele ferramentas que nos ajudam a realiar as tarefas
            //como adiocionar um tem a nossa lista de livros
            LivrosController lv = new LivrosController();
            lv.Livros.Add(new Livro()

            { //Aqui "atribuimos" o nme que demos ao livro na propriedade Nome do nosso livro
                //Com o sinal de apenas u "=" temos atribui~ção,passagem de valor
                Nome = nomeDoLivro
            });
            //Indico que finalizamos o processo de cadastro do livro, assim o uduario já sabe
            //que o nome foi realiar e sem erros
            Console.WriteLine("Livro cadastrado com sucesso!");
            //ReadKey apenas para que ele visualize esta informação.
            Console.ReadKey();
        }



        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do
        /// sistema como solicitação de login e senha pelo console,assim como a 
        /// respectiva validação que o mesmo precisa entrar no sistema.
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e 
        /// senha infromados estiverem estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {

            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            Usuarios usuario = new Usuarios();
            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);
        }

        private static void ListarLivro()
        {
            Console.Clear();
            Livros livro = new Livros()
            {
                Nome = "O incrível mundo de Java"
            };

            Console.WriteLine($"Nome: {livro.Nome}");
            Console.WriteLine("----- DIGITE QUALQUER TECLA PRA SAIR -----");
            Console.ReadKey();
        }


    }


}
