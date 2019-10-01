using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejass.Model
{
    public class SistemaCervejaContext
    {
        public SistemaCervejaContext()
        {
            ListaCervejaPublica = new List<Cerveja>
            {
                new Cerveja() { Id = IdAutoGerado++, Nome = "Budweiser", Litros = 1, Alcool = 5.1, Valor = 8.90 },
                new Cerveja() { Id = IdAutoGerado++, Nome = "Brahma", Litros = 1, Alcool = 4.2, Valor = 6.19 },
                new Cerveja() { Id = IdAutoGerado++, Nome = "Original", Litros = 1, Alcool = 5.3, Valor = 5.49 },
                new Cerveja() { Id = IdAutoGerado++, Nome = "Skol", Litros = 1, Alcool = 5.0, Valor = 6.80 },
                new Cerveja() { Id = IdAutoGerado++, Nome = "Polar", Litros = 1, Alcool = 5.1, Valor = 6.29 }
            };
        }
       
        public List<Cerveja> ListaCervejaPublica { get; set; }

        public int IdAutoGerado { get; set; } = 1;

    }
}
