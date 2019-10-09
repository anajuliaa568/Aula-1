using ExercicioAmigo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAmigo
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigo = new List<Amigo>();
            var amigo = new Amigo();
            var amigoDois = new Amigo();
            var amigoTres = new Amigo();
            amigo.Nome = "Ana Julia";
            amigo.TempoDeAmizade = 4;
            listaAmigo.Add(amigo);
            amigoDois.Nome = "Estéfani";
            amigoDois.TempoDeAmizade = 4;
            listaAmigo.Add(amigoDois);
            amigoTres.Nome = "Filipe";
            amigoTres.TempoDeAmizade = 1;
            listaAmigo.Add(amigoTres);
            listaAmigo.ForEach(i => Console.WriteLine($"Nome: {i.Nome}     Tempo Amizade: {i.TempoDeAmizade}"));
            Console.ReadKey();

        }
    }
}
