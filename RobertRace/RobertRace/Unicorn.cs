using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRace
{
    class Unicorn : Animal //Unicorn är en sorts Animal
    {
        public Unicorn()
        {

            //Konstruktor av Unicorn som innehåller, typ av djur, hastighet som varierar sig från Björnen,
            //Den har sin egna energyMax och dess nuvarande energi!
            type = "Unicorn";
            speed = 3;
            energyMax = 8;
            energyCurrent = 8;
        }
    }
}
