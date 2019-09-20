using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{/// <summary>
/// Classe que contem os metodos de usuários do sistema
/// </summary>
    public class UsuarioController

       
    {
        //boolean responde somente sim ou não
        /// <summary>
        /// Metodo que realiza login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="usuarios">passamos um objeto Usuario como parametro</param>
        /// <returns>Retorna verdadeiro quado existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuarios usuarios)
    {
        if (usuarios.Login == "Admin" && usuarios.Senha == "Admin")
            return true;
        else
            return false;

    } 
    }
}
