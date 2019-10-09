using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityClass.Model
{
    public class Pessoa
    { //Aqui temos uma anotação que indica que nossa chave é
        //o campo logo abaixo da nossa anotação e a 
        [Key]
        public int id { get; set; }
        public string Nome { get; set;}
    }
}
