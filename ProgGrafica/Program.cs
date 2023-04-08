using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgGrafica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Game game = new Game(500,500,"Triangulo");
            game.Run();
        }
    }
}
