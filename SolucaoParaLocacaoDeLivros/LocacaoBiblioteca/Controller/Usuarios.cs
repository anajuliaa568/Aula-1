using System;

namespace LocacaoBiblioteca.Controller
{
    public class Usuarios
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime Datacriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}