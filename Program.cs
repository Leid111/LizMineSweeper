using System;

namespace LizMineSweeper 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play MineSweeper!");

            BombAwareness(59);
        }




        static void BombAwareness(int UserGuess1)
        {
            //int[] bombNumberarray = new int[] { 48, 59, 5, 2, 6, 7, 8, 9, 10, 20 }; // random bumbers generates     // make sure  that doesnt let it repeat numbers 
            List<int> MinesNumbers = new List<int>();
            MinesNumbers.Add(48);
            MinesNumbers.Add(59);
            MinesNumbers.Add(5);
            MinesNumbers.Add(2);
            MinesNumbers.Add(6);
            MinesNumbers.Add(7);
            MinesNumbers.Add(8);
            MinesNumbers.Add(9);
            MinesNumbers.Add(10);
            MinesNumbers.Add(20);

            int UserGuess = UserGuess1; //user input 
            int count = 0;



            for (int i = 0; i < MinesNumbers.Count; i++)
            {
                if (UserGuess == MinesNumbers[i])
                {
                    Console.WriteLine("BOOM!Game Over.");
                    break;
                }
                if (UserGuess + 1 == MinesNumbers[i])
                {
                    count++;
                }
                
                 if  (UserGuess - 1 == MinesNumbers[i])
                {
                    count++;
                }
                 if (UserGuess + 11 == MinesNumbers[i])
                {
                    count++;
                    
                }
                 if (UserGuess - 11 == MinesNumbers[i])
                {
                    count++;
                  
                }
                 if (UserGuess - 10 == MinesNumbers[i])
                {
                    count++;
                   
                }
                if (UserGuess + 10 == MinesNumbers[i])
                {
                    count++;
                   
                }
                 if (UserGuess + 9 == MinesNumbers[i])
                {
                    count++;
                    
                }
                 if (UserGuess - 9 == MinesNumbers[i])
                {
                    count++;
                   
                }
                
            }
           if ( count > 0 && count <=8 
                && !(UserGuess == MinesNumbers[0]) 
                && !(UserGuess == MinesNumbers[1])
                && !(UserGuess == MinesNumbers[2])
                && !(UserGuess == MinesNumbers[2])
                && !(UserGuess == MinesNumbers[4])
                &&!(UserGuess == MinesNumbers[5])
                && !(UserGuess == MinesNumbers[6])
                && !(UserGuess == MinesNumbers[7])
                && !(UserGuess == MinesNumbers[8])
                && !(UserGuess == MinesNumbers[9]))

                Console.WriteLine($"There are {count} bombs near you");
        }

    }
}