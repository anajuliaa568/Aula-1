using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class CelularesContextDB  //Definimos uma herança
        : DbContext             //Aqui definimos que vamos herdar toda a caixa de ferramentas do EntityFramework
       

    {
        //Definimos nossa primeira tabela no banco de dados
        public DbSet<Usuário> Usuários { get; set; }

        //Definimos nossa tabela de celulares
        public DbSet<Celular> Celulares { get; set; }
    }
}
