using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRace
{
    class Animal
    {
        // Unika värden
        public int speed;
        public int energyCurrent;
        public int energyMax;

        // Alla djur börjar på position 0
        public int position = 0;

        // Vad för djur
        public string type;

        static Random generator = new Random();






        public void Animalpicker()
        {



        }


        public void Move()
        {
            // Rör sig framåt ifall energy är över 0
            if (energyCurrent > 0)
            {
                // Gå framåt antal steg, mellan 1 och djurets speed (+1 på grund av att max värdet inte inkluderas)
                position += generator.Next(1, speed + 1);

                energyCurrent--;

                // Låt inte position gå över 20
                if (position > 20)
                {
                    position = 20;
                }

                // Låt inte energyCurrent gå under 0
                if (energyCurrent <= 0)
                {
                    energyCurrent = 0;
                }
            }
        }

        // Återställ energyCurrent till energyMax
        public void Rest()
        {
            energyCurrent = energyMax;
        }

        // Skriv ut alla nuvarande stats
        public void Printstats()
        {
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Energy: " + energyCurrent + "/" + energyMax);
        }
    }
}

