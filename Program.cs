using System;

namespace LizMineSweeper 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play MineSweeper!");

            BombAwareness();  
            
        }

        static void BombAwareness() 
        {
           
            Mines mines = new Mines();
            mines.GenerateBombs();
            int UserGuess = 0;
            int count = 0;
            while (mines.CheckUserGuess(UserGuess)) 
            {
                count = 0;
                Console.WriteLine("Enter a coordinate ( a number between 1-100)");
                try { UserGuess = Int32.Parse(Console.ReadLine()); }
                catch (Exception e) { Console.WriteLine("Invaild Coordinate.Try Agin"); }
                
               if(!(UserGuess >=0 && UserGuess <= 100))
                {
                    Console.WriteLine("Not a valid input, try again.");
                }

                mines.CheckIfUserGuessIsBomb(UserGuess);
                mines.AddValidGuessToTotalGuesses(UserGuess);
                
                if (mines.CheckIfTheyAreAWinner())
                {
                    Console.WriteLine("Congrats! You've Won");
                    break;
                }
            }
           
            
        }
        }

       
}