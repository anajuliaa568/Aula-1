using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroDePessoasComListagem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random rdm = new Random();

            HashSet<int> dados = new HashSet<int>();
            dados.Add(30);
            dados.Add(30);




            for (int w = 0; w < 10; w++)
            {    //Gera um número aleatório de 0 a 100
                int valorGeradoAleatoriamente = rdm.Next(100);
                //Verifica se a lista não contém este número gerado
                if (!numeros.Contains(valorGeradoAleatoriamente))
                {    //Adiciona o número gerado pelo random(que não é repetido).
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    w--;
                }
            }
            Console.ReadLine();




        }
    }
}
