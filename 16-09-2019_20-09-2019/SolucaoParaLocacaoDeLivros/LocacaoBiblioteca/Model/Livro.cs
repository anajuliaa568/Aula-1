﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Livro
    {
        public string Id { get;  set; }
        public string Nome { get;  set; }
        public bool Ativo { get;  set; }
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime Datacriacao { get;  set; }
        public DateTime DataAlteracao { get;  set; }

        
    }
}
