using System;
using System.Threading;

namespace Number_Guesser_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SlowType("Hello Welcome to Number Guesser");
            SlowType("Please Enter Your Name To Proceed: ", 0);
            string name = Console.ReadLine();
            SlowType("Great " + name.ToUpper());
            int min = 1;
            int max = 100;
            double mid = ((max + min) / 2);


            Random numberGenerator = new Random();

            int value = numberGenerator.Next(min, max);
            SlowType(value.ToString(), 2);
          
            SlowType(name.ToUpper() + ", I am thinking of a number between " + min + " and " + max, 2);
            SlowType("'Up' arrow rep higher, 'Down arrow' rep lower and the 'Spacebar' rep equals", 2);
            

            bool correct = false;

            for (int trialNumber = 10; trialNumber > 0; trialNumber--)
            {
                
                SlowType("Do you think the number is higher, lower or equal to " + mid + "?", 2);
               
                SlowType("You have " + trialNumber + " trials left", 2);
                SlowType("Enter your response:");
                ConsoleKeyInfo response = Console.ReadKey();


                if (response.Key == ConsoleKey.UpArrow || response.Key == ConsoleKey.U)
                {
                    Console.CursorLeft = 0;
                    SlowType("You've selected higher than " + mid, 3);
                    if (value > mid)
                    {

                        min = Convert.ToInt32(mid);
                        SlowType("Right, the number is greater than " + mid);
                    }
                    else
                    {
                        SlowType("Wrong, it is not greater than " + mid);
                    }
                }
                else if (response.Key== ConsoleKey.DownArrow || response.Key==ConsoleKey.D)
                {
                    Console.CursorLeft = 0;
                    SlowType("You've clicked the down arrow", 3);
                    if (value < mid)
                    {

                        max = Convert.ToInt32(mid);
                        SlowType("Right, the number is less than " + mid);
                    }
                    else
                    {
                        SlowType("Wrong, it is not less than " + mid);
                    }


                }
                else if (response.Key==ConsoleKey.Spacebar)
                {
                    Console.CursorLeft = 0;
                    SlowType("You've clicked the spacebar", 3);
                    if (value == mid)
                    {
                        correct = true;
                        SlowType("Correct");
                        break;
                    }
                    else
                    {
                        SlowType("Wrong, it is not equal to " + mid);
                    }

                }
                else
                {
                    Console.WriteLine();
                    SlowType("Sorry, you've pressed the wrong key");
                    trialNumber++;
               
                }

                    

                mid = ((max + min) / 2);

                //SlowType("mid=" + mid);
                //SlowType("max=" + max);
                //SlowType("min=" + min);


            }

            if (!correct)
            {
                SlowType("GAME OVER");


            }
            else
            {
                SlowType("YOU WIN...CONGRATULATIONS");

                
            }
            SlowType("Press any key to exit");

            Console.ReadKey();
                
        }
	

        static void SlowType(string alpha, int spaceNumbers = 1)
        {
            foreach (char l in alpha)
            {
                Console.Write(l);
                Thread.Sleep(25);

            }
           
            for (int i = 0; i < spaceNumbers; i++)
            {
                Console.WriteLine();

            }
        }
	}
}

