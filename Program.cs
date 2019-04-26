using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {


       
        public static void Main(string[] args)
        {
            bool playAgain = true;
            while(playAgain == true)
            {
                Console.WriteLine("Please enter number of sides for your dice good sir");
                int max1 = int.Parse(Console.ReadLine());

                Console.WriteLine("How many dice do you have?");
                int dice1 = int.Parse(Console.ReadLine());

                int totals = Roll(max1, dice1);
                Console.WriteLine("The total for {0} dice was {1}.", dice1, totals);
                Console.WriteLine();
                Console.WriteLine("Do you want to roll again? Y/N ");
                string input = Console.ReadLine().ToUpper();
                if(input == "Y")
                {
                    playAgain = true;
                }
                if(input == "N")
                {
                    Console.WriteLine("Well thanks for playing, I only spent all day on this game geeeez jk. ");
                    playAgain = false;
                }
                
            }


        }

        public static int GetRandom(int max)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, max +1);
            return randomNumber;

        }

        public static int Roll(int sides, int dice)
        {
            int results = 0;

            for(int i = 1; i < dice; i++)
            {

                results = results + GetRandom(sides);

            }

            return results;

        }

    

      
        
            


    }
}
