using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixamos a clase pública
   public class Celular : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]               //Definição de tamanho maximo de campo
        [Required]                    //Definindo campo obrigatorio
        public string Marca { get; set; } 
        [MaxLength(30)]               //Definição de tamanho maximo de campo
        [Required]                    //Definindo campo obrigatorio
        public string Modelo { get; set; }
        [Required]                    //Definindo campo obrigatorio
        public double Preco { get; set; }
    }
}
