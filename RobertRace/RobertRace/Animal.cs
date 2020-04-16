using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRace
{
    class Animal
    {
        public int speed;
        public int position = 0;
        public int energycurrent = 20;
        public int energyMax = 20;

        static Random generator = new Random();

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
            Console.WriteLine("EnergyCurrent = " + energycurrent);
            Console.WriteLine("Position = " + position);
            Console.WriteLine("Speed = " + speed);
        }

    }
}
