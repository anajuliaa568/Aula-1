using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{ //Inicialmente devemos deixar a classe pública
    public class Cerveja
    {   
        //Chamada pelo (Ctrl + '.') ponto
        [Key] //Chave primaria, auto incrementada
        public int Id { get; set; }
                                 //Aqui definimos a quantidade maxima de caracteres
        [StringLength(50)]       //para nosso campo "Nome" dentro do campo
        [Required]           //Identifica que este campo é obrigatório
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double Teor { get; set; }

    }
}
