using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    //1- Usar nossa pasta model 'using CatalogoCelulares.Model;'
    //2- Criar uma instancia nova da nossa context

    //Deixar a classe pública
    public class CelularesController
    {
        //Iniciamos nossa instancia com a base de dados dentro da controller
        CelularesContextDB contextDB = new CelularesContextDB();

        //Listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativo apenas
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB     //Nosso Acesso ao BD
                .Celulares       //Nossa tabela do BD
                .Where           //Indicamos que vamos realizar um filtro
                (x => x.Ativo == true);   //As condiçoes do filtro

        }
        //Atualização
        /// <summary>
        /// Metodo que atualiza um registro válido do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna verdadeiro casa item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular =  //Definimos uma variável para o celular
                 contextDB  //Usamos o BD
                 .Celulares //Nossa tabela que tem o celulares
                 .FirstOrDefault   //Buscamos em nossa tabela o celular
                 (x => x.Id == item.Id);  //Regra para realizar a busca

            //Falamos que nosso celular da tabela vai ser igual
            //Nosso celular que estamos passando

            if (celular == null)  //Verificamos que ele realmente encontrou um celular
                return false;     //Caso nao tenha encontrado retornamos falso
            else
            {
                celular = item;       //Encontrou ele atualiza a informação
                celular.DataAlteracao = DateTime.Now;
                //Atualizamos a data da alteração do nosso celular
            }
            contextDB.SaveChanges();  //Salvamos a informação no banco

            return true; //Retornamos que foi atualizado
        }


        //Inserção
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item</returns>
        public bool inserirCelular(Celular item)
        {
            if (string  //nosso tipo que contem varios metodos prontos para string
                    .IsNullOrWhiteSpace   //Metodo que identifica espaços em branco
                                          //apenas ou valor Null
             (item.Marca))            //Nosso campo que vamos validar
              return false;

            if (string
                .IsNullOrWhiteSpace
                (item.Modelo))
                return false;

            if (item.Preco <= 0)  //Verificamos se o valor informado é maior que 0
                return false;     //Caso não, ele ja retorna para a fora do método

            contextDB.Celulares.Add(item); //Salvamos nosso item dentro da nossa tabela em memória
            contextDB.SaveChanges();  //Salvamos agora no banco de informçoes

            return true; //Retornamos verdadeiro para indicar sucesso na inserção do registro
        }

        //'Remoção'
        /// <summary>
        /// Metodo utilizado para apenas desativar o item de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)

        {
            var celular =   //Nossa variável
                contextDB   //Nossa BD
                .Celulares  //Tabela de celular
                .FirstOrDefault  //Buscamos o item para desativar 
                (x => x.Id == id); //Informamos a regra de busca por Id 

            if (celular == null) //Verificamos se este item existe
                return false; //Caso não, ele sai deste método

            celular.Ativo = false;  //Desativamos o item

            contextDB.SaveChanges(); // Salvamos em nosso banco

            return true; //Retornamos verdadeiro


        }
    }
}