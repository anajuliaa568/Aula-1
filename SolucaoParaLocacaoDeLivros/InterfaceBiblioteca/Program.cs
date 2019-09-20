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
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            Console.WriteLine("Menu Sistema");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar usuários");
            Console.WriteLine("2 - Lista Livro");
            Console.WriteLine("3 -Cadastrar Livro");

            //Aqui vamos egar numero digitado
            //Executar proxima funcao
            Console.Write("Sua opção: ");
            var situacao = Console.ReadLine();
            switch (situacao)
            {

                case "2":
                    ListarLivro();
            MostraMenuSistema();
            break;
            default:
                    break;
        }
        }

        /// <summary>
        /// Metodo que realiza os procedimentos completos de login dentro do
        /// sistema como solicitação de login e senha pelo console,assim como a 
        /// respectiva validação que o mesmo precisa entrar no sistema.
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e 
        /// senha infromados estiverem corretos.</returns>
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
                Nome = "O incrivel mundo de Java"
            };

            Console.WriteLine($"Nome: {livro.Nome}");
            Console.WriteLine("----- DIGITE QUALQUER TECLA PRA SAIR -----");
            Console.ReadKey();
        }

            
    }


}
