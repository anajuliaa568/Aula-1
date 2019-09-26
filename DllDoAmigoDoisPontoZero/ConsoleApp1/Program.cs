using System;
using ListagemDeCarros.Controller;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroController cc = new CarroController();
            cc.GetCarros().ForEach(i => Console.WriteLine($"{i.Id}    {i.Marca}    {i.Modelo}"));
        }
    }
}
