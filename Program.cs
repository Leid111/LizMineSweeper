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

        static void BombAwareness() // thinking of adding list as a para List<int> MineNumbers? 
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
            List<int> TotalUserGuesses = new List<int>();
           
            int UserGuess = 0;
            int count = 0;
            while(!(UserGuess == MinesNumbers[0])
                && !(UserGuess == MinesNumbers[1])
                && !(UserGuess == MinesNumbers[2])
                && !(UserGuess == MinesNumbers[3])
                && !(UserGuess == MinesNumbers[4])
                && !(UserGuess == MinesNumbers[5])
                && !(UserGuess == MinesNumbers[6])
                && !(UserGuess == MinesNumbers[7])
                && !(UserGuess == MinesNumbers[8])
                && !(UserGuess == MinesNumbers[9])
                )
            {
                
                Console.WriteLine("Enter a coordinate ( a number between 1-100)");
                UserGuess = Int32.Parse(Console.ReadLine());
               


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

                TotalUserGuesses.Add(UserGuess);
                if (count > 0 && count <= 8
                 && !(UserGuess == MinesNumbers[0])
                 && !(UserGuess == MinesNumbers[1])
                 && !(UserGuess == MinesNumbers[2])
                 && !(UserGuess == MinesNumbers[2])
                 && !(UserGuess == MinesNumbers[4])
                 && !(UserGuess == MinesNumbers[5])
                 && !(UserGuess == MinesNumbers[6])
                 && !(UserGuess == MinesNumbers[7])
                 && !(UserGuess == MinesNumbers[8])
                 && !(UserGuess == MinesNumbers[9]))

                Console.WriteLine($"There are {count} bombs near you");
            count = 0;

                if (TotalUserGuesses.Count == 89 
                    && !(TotalUserGuesses.Contains(MinesNumbers[0]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[1]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[2]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[3]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[4]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[5]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[6]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[7]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[8]))
                    && !(TotalUserGuesses.Contains(MinesNumbers[9]))
                    )
                    {

                    Console.WriteLine("Congrats! You've Won");
                    break;
                }

                //else UserInput(); - this allowed me to add another coordinate but then didnt apply the checks again? 
            }
        }

        

    }
}