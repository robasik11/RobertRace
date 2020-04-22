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
            if (energycurrent >= 1)
            {
                position++;
                energycurrent--;
                if (energycurrent <= 0)
                {
                    energycurrent = 20;

                }

            }

        }

        public void Rest()
        {
            energycurrent = energyMax;

        }

        public void Printstats()
        {
            Console.WriteLine(name);
            Console.WriteLine("EnergyCurrent = " + energycurrent);
            Console.WriteLine("Position = " + position);
            Console.WriteLine("Speed = " + speed);
        }

    }
}
