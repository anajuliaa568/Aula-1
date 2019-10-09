using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityClass.Controller;
using entityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();

        static void Main(string[] args)
        {
            pessoa.AddPessoa( //Aqui utilizamos o metodo da controller para
             new Pessoa()    //adicionar a pessoa em nossa lista
            {
                    Nome = "Ana"    //novo registro

            });  //O metodo AddPessoa tem o saveChange que realiza a gravação
                //das informaçoes em nosso banco de dados

            pessoa.GetPessoas()  //Obtemos as lista de pessoas
                .ToList<Pessoa>()  //Convertemos para uma lista de pesssoas
                .ForEach(x => Console.WriteLine(x.Nome));  //Mostramos em nosso console

            Console.ReadKey();
        }
    }
}
