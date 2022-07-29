using System;

namespace Lanterna
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanterna lanterna = new Lanterna();
            Console.WriteLine("------LÂNTERNA------");
            lanterna.RenovarCarga();
            lanterna.EstadoLanterna();
            lanterna.LigarLanterna();
            lanterna.EstadoLanterna();

            Console.ReadKey();
           
        }
    }
}
