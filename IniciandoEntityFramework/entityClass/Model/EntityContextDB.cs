using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityClass.Model
{
    public class EntityContextDB : 
        DbContext // DBContext CLASSE PRONTA QUE CONTEM TODOS OS PROCESSOS
        //DA CONEXAO COM O BANCO DE DADOS,LISTAGEM DAS TABELAS 
        //SELECAO DE INFORMACOES
       
    {
        public DbSet//PALAVRA RESERVADA PARA O ENTITY QUE INDICA QUE VAMOS
            //DEFINIR UMA TABELA DO NOSSO BANCO DE DADOS


        <Pessoa> //AQUI DEFINIMOS QUAL DE NOSSAS CLASSES SERA UMA REFERENCIA
            //DE UMA TABELA NO BANCO DE DADOS
            //ELA VAI AO BANCO COM NOME QUE DEFINIMOS EM NOSSA TABELA

        listaDePEssoas { get; set; } // NESTA PARTE LIBERAMOS NOSSA TABELA PARA ACESSAR
    }
}
