using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixar a classe pública
    public class ControleUsuario
    {
        public bool Ativo { get; set; } = true;  //Definimos o campo com o valor default 'true'
                                                 //para nossos registros
        public int UsuarioCriacao { get; set; } = 0; //Definimos 0 para usuari criado pelo sistema sem usuario logado

        public int UsuarioAlteracao {get; set;} = 0; //Setamos nossa data criancao para data atual pela classe DateTime

        public DateTime DataCriacao { get; set; } = DateTime.Now;  //Aqui definimos quando nao informada para data de alteracao a data atual

        public DateTime DataAlteracao { get; set; } = DateTime.Now;  
    }
}
