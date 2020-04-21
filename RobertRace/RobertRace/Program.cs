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
            Unicorn Unicorn = new Unicorn();
            Teddybear Teddybear = new Teddybear();
            Animal Animal = new Animal();
            List<Animal> Animals = new List<Animal>();
            int a = 0;












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
