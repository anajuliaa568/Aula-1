using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {/// <summary>
    /// Metodo  para retornar a área de um quadrado
    /// </summary>
    /// <param name="ladoQuadrado">Lado do Quadrado</param>
    /// <returns>Retorna a área total do quadrado com precisão inteira</returns>
        public double CalculaAreaDoQuadrado(int ladoQuadrado)
        {
            return ladoQuadrado* ladoQuadrado;

        }
    }
}
