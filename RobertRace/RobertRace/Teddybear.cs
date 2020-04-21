using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRace
{
    class Teddybear : Animal //Björnen är ett sorts Djur
    {
        public Teddybear()
        {
            //Detta är björnens kronstruktor med alla variablar, skiljer sig från enhörningen.
            type = "Teddybear";
            speed = 2;
            energyMax = 10;
            energyCurrent = 10;
        }
    }
}
