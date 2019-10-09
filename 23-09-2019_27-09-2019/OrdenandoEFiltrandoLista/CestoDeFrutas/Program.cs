using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Codando muito
            var cestaDeFrutas = new List<Fruta>();

            //Vamos no mercado - TOMATE
            cestaDeFrutas.Add(new Fruta()

            {
                id = 0 ,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });

            //Vamos no mercado - GOIABA
            cestaDeFrutas.Add(new Fruta()

            {
                id = 1 ,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });

            //Vamos no mercado - MANGA
            cestaDeFrutas.Add(new Fruta()

            {
                id = 2 ,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            #endregion

            var cestoDeFrutas = new List<Fruta>();

            #region Lista 1
            cestaDeFrutas
                //Neste ponto ordenamos os valores de forma decrescente pelo nome
                .OrderByDescending(x => x.id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id{i.id} Nome: {i.Nome}"));

            #endregion
            Console.WriteLine("---------------------");

            #region Lista 2
            cestaDeFrutas
                //Aqui ordenamos os valores pelo Id de forma crescente
                .OrderByDescending(x => x.id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id{i.id} Nome: {i.Nome}"));
            #endregion

            Console.WriteLine("--------------------- Filtro Peso");

            #region Lista 3
            var filtroCesta = cestaDeFrutas
                //Aqui filtramos os registros maiores de 100 gramas
                .Where(x => x.Peso > 100)
                //Ordenamos estes valores pelo nome
                .OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.id} Nome {i.Nome} Peso {i.Peso}"));

            //frutinha recebe cada fruta de nossa cesta
            (from frutinha in cestaDeFrutas//<- Aqui temos a coleção de frutas
                       where frutinha.Peso > 100 //<- Aqui escolhemos somente frutas com mais de 100g
                       select frutinha) //< -Neste ponto eu junto as informaçoes que filtrarei e retorno
                       .ToList<Fruta>() //<-Convertemos para uma lista
                      .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));
            #endregion

            Console.WriteLine("--------------------- Filtro Cores");

            // Aqui criamos uma variável que recebera o valor buscado.
            var mostrandoFind = cestaDeFrutas
            //Aqui é feito o filtro das informações por uma "ou --> || <--- " outra cor.
            .Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {mostrandoFind.id} Nome {mostrandoFind.Nome}");
            //Aqui criamos uma variável que recebera a coleção que estamos buscando.
            var mostrandoFindAll = cestaDeFrutas
            //Find All com esta condição tras frutas de cor amarela "ou" vermelha.
            .FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            //imprimo com a função do ForEach do linq                                                                    
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.id} Nome {i.Nome}"));
            //Aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //Como agora ele não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
            Console.WriteLine($"Id {item.id} Nome {item.Nome}");
            Console.WriteLine("------------------------- Find com order by");
            var cestoDeFrutasFindOrder = cestaDeFrutas
            //Ordenei miha lista
            .OrderBy(x => x.Nome)
            //Converti para lista de fruta novamente
            .ToList<Fruta>()
            //Busco minha informção
            .Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {cestoDeFrutasFindOrder.id} Nome {cestoDeFrutasFindOrder.Nome}");

            Console.ReadKey();

          

        }
    }
}
