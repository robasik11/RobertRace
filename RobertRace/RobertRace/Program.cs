using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobertRace
{
    class Program
    {
        // Random generator
        static Random generator = new Random();


        static void Main(string[] args)
        {
            // Steg 1: Skapa djur 

            // Lista till alla djur
            List<Animal> animalList = new List<Animal>();

            // Oändlig loop tills användaren skrivit en siffra
            while (true)
            {
                Console.WriteLine("How many animals would you like to create...");

                // Ta in ett värde från användaren
                string aValue = Console.ReadLine();

                // Försök omvandla till en int
                bool success = int.TryParse(aValue, out int answer);

                // Ifall omvandlingen gick bra samt över 0
                if (success && answer > 0)
                {
                    // Slumpa fram så många djur som användaren valde
                    for (int i = 0; i < answer; i++)
                    {
                        int rndNumber = generator.Next(2);

                        // Skapa ett djur och skriv ut dess stats
                        if (rndNumber == 0)
                        {
                            Console.WriteLine("Created a Unicorn");
                            animalList.Add(new Unicorn());
                            animalList[i].Printstats();
                        }

                        else if (rndNumber == 1)
                        {
                            Console.WriteLine("Created a Teddybear");
                            animalList.Add(new Teddybear());
                            animalList[i].Printstats();
                        }

                        Console.WriteLine("------------------");
                    }










                    while (a == 0)
            {

                try
                {

                    Random rnd = new Random();
                    int answer;
                    string aValue;
                    Console.WriteLine("How many animals would you like to create\nYou need to use numbers..");
                    aValue = Console.ReadLine();
                    answer = int.Parse(aValue);


                    if (answer >= 1)
                    {
                        for (int i = 0; i < answer; i++)
                        {
                            int rndNumber = rnd.Next(4);

                            switch (rndNumber)
                            {
                                case 0:
                                    Animals.Add(new Unicorn());
                                    break;
                                case 1:
                                    Animals.Add(new Teddybear());
                                    break;





                            }

                            break;

                        }
                        for (int i = answer; i < Animals.Count; i++)
                        {
                            Console.WriteLine(Animals[i].name);
                            Console.ReadKey();

                        }

                    }
                    else
                    {
                        Console.WriteLine("You need to use a number with the value one or above..");
                    }







                }
                catch
                {


                }
            }




        }
    }
}
