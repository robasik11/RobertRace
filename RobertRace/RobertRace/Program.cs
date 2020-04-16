using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Animal = new Animal();
            Animal.Printstats();
            Console.ReadKey();
            Animal.Move();
            Animal.Printstats();
            Console.ReadKey();

        }
    }
}
