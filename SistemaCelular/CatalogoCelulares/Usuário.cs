using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares
{
    public class Usuário : ControleUsuario
    {
        [Key]                          //Definindo como primary key e identity(1,1)
        public int Id { get; set; }
        [MaxLength(50)]                //Delimitamos um tamanho máximo para o campo String
        public string Nome { get; set; }
        [MaxLength(30)]                //Delimitamos o tamanho do campo
        [Required]                     //Definimos que este campo é obrigatório
        public string Login { get; set; }
        [MaxLength(30)]                //Delimitamos o tamanho do campo
        [Required]                     //Definimos que este campo é obrigatório
        public string Senha { get; set; }
    }
}
