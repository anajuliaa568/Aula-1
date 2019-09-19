using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCalculoQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, area;
           
            Console.Write("Digite o valor do lado : ");
            
           
            l = Convert.ToDouble(Console.ReadLine());
            
         
            area = l * l;
           
            Console.WriteLine("A área do quadrado é: " + area.ToString("F2"));
            Console.WriteLine("Pressione qualquer tecla para finalizar!");
            Console.ReadKey();
        }
    }
    }

