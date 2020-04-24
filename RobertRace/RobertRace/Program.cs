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


                    Console.WriteLine("Press any key to you continue!");

                    Console.ReadKey();

                    // Skapat alla djur, så lämna while-loop
                    break;
                }


                // Användaren skrev en int men inte med värde över 0
                else if (success)
                {
                    Console.WriteLine("\nYou need to use a number with the value one or above..\n");
                }

                // Användaren skrev inte en int
                else
                {
                    Console.WriteLine("\nYou need to write an int!\n");
                }
            }

            Console.Clear();


            // Steg 2: Race

            // Slumpa ett djur som ska racea
            Animal raceAnimal = animalList[generator.Next(animalList.Count)];

            Console.WriteLine("The chosen animal is...");
            Console.WriteLine(raceAnimal.type);

            Console.WriteLine("Press any key to start the race!");

            Console.ReadKey();
            Console.Clear();

            int round = 0;


            while (true)
            {
                Console.WriteLine("Round: " + round);
                raceAnimal.Printstats();
                Console.WriteLine("-------------------");

                // Oändlig loop tills användaren skrivit 1 eller 2
                while (true)
                {
                    Console.WriteLine("Choose an option.");
                    Console.WriteLine("1 = Move, 2 = Rest");

                    // Ta in ett värde från användaren
                    string aValue = Console.ReadLine();

                    // Försök omvandla till en int
                    int.TryParse(aValue, out int answer);

                    // Ifall användaren skrev 1
                    if (answer == 1)
                    {
                        raceAnimal.Move();
                        break;
                    }

                    // Ifall användaren skrev 2 
                    else if (answer == 2)
                    {
                        raceAnimal.Rest();
                        break;
                    }

                    // Användaren skrev en int men inte mellan 1-2
                    else
                    {
                        Console.WriteLine("\nYou need to write an int between 1-2!\n");
                    }
                }

                // Djuret har klarat loppet
                if (raceAnimal.position == 20)
                {
                    Console.WriteLine("Congratulations! You won!");
                    Console.ReadKey();
                    break;
                }

                // Gör till nästa runda
                else
                {
                    round++;
                }

                Console.Clear();
            }




        }
    }
}
