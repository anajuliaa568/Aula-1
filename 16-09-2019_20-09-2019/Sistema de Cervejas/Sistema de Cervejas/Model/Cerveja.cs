using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cervejas.Model
{
   public class Cerveja
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public Double Litros { get; set; }
        public Double Álcool { get; set; }
        public Double Valor { get; set; }
    }
}
