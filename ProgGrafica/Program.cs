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
            Console.WriteLine("Jeon Jungkook");
            Game game = new Game(500,500,"BTS");
            game.Run();
        }
    }
}
