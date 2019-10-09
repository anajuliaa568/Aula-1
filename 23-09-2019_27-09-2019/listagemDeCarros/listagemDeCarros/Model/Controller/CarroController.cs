using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listagemDeCarros.Model.Controller
{
    class CarroController
    {
        SistemaCarrosContext carrosContext = new SistemaCarrosContext();

        /// <summary>
        /// Metodo que retorna nossa lista de carros completa
        /// </summary>
        /// <returs>Retorna nossa lista de carros</returs>
        public void ListCarros ()
        {
            carrosContext.ListaDeCarros.ForEach(i => Console.WriteLine($"id {i.id} Marca {i.Marca} Modelo {i.Modelo} Ano {i.Ano} Cilindradas {i.Cilindradas} Portas {i.Portas}"));
        }




    }
}