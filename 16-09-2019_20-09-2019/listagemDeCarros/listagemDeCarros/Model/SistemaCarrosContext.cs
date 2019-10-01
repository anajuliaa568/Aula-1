using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listagemDeCarros.Model
{
    public class SistemaCarrosContext
    {

        public List<Carro> ListaDeCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { id = 1, Marca = "Chevrolet", Modelo = "Onix", Ano = 2013, Cilindradas = 400, Portas = 4 });
            ListaDeCarros.Add(new Carro() { id = 2, Marca = "Fiat", Modelo = "Uno", Ano = 2014, Cilindradas = 150, Portas = 4 });
            ListaDeCarros.Add(new Carro() { id = 3, Marca = "Volkswagem", Modelo = "Gol", Ano = 2016, Cilindradas = 350, Portas = 2 });
            ListaDeCarros.Add(new Carro() { id = 4, Marca = "Toyota", Modelo = "Corolla", Ano = 2017, Cilindradas = 500, Portas = 4 });
            ListaDeCarros.Add(new Carro() { id = 5, Marca = "Hyundai", Modelo = "Tucson", Ano = 2016, Cilindradas = 500, Portas = 2 });
            ListaDeCarros.Add(new Carro() { id = 6, Marca = "Fiat", Modelo = "Strada", Ano = 2010, Cilindradas = 200, Portas = 4 });
            ListaDeCarros.Add(new Carro() { id = 7, Marca = "Ford", Modelo = "Focus", Ano = 2015, Cilindradas = 200, Portas = 2 });
            ListaDeCarros.Add(new Carro() { id = 8, Marca = "Renault", Modelo = "Sandero", Ano = 2013, Cilindradas = 250, Portas = 4 });
            ListaDeCarros.Add(new Carro() { id = 9, Marca = "Honda", Modelo = "Civic", Ano = 2016, Cilindradas = 400, Portas = 4 });
            ListaDeCarros.Add(new Carro() { id = 10,Marca = "Ford", Modelo = "Fiesta", Ano = 2010, Cilindradas = 150, Portas = 2 });

            Console.ReadKey();
        }
        
       
        

             

    }
}