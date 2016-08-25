using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 11);
            Console.WriteLine("Guess a number from 0 thru 10");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    int guessedNumber = Convert.ToInt32(Console.ReadLine());
                    if (guessedNumber != randomNumber)
                    {
                        if (i < 4)
                        {
                            Console.WriteLine("No try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You win");
                        return;
                    }
                }

                catch(Exception)
                {
                    i = (i - 1);
                    Console.WriteLine("Exception Caught");
                }
            }
            Console.WriteLine("You lose");
            Console.WriteLine(randomNumber);
            Console.ReadLine();
        }
    }
}