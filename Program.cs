using System;

namespace LizMineSweeper 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BombAwareness(58);
        }

        //static void ContainsBomb(int UserInput)
        //{
        //    int[] bombNumberarray = new int[] { 48, 59, 5, 2, 6, 7, 8, 9, 10, 20 };
        //    if (UserInput !== )
        //}

        static void BombAwareness(int UserGuess)
        {
            int[] bombNumberarray = new int[] { 48, 59, 5, 2, 6, 7, 8, 9, 10, 20 }; // random bumbers generates     // make sure  that doesnt let it repeat numbers 
            int x = UserGuess; //user input 
            int count = 0;

            for (int i = 0; i < bombNumberarray.Length; i++)
            {
                if (x + 1 == bombNumberarray[i])
                {
                    count++;
                }
                
                 if  (x - 1 == bombNumberarray[i])
                {
                    count++;
                }
                 if (x + 11 == bombNumberarray[i])
                {
                    count++;
                    
                }
                 if (x - 11 == bombNumberarray[i])
                {
                    count++;
                  
                }
                 if (x - 10 == bombNumberarray[i])
                {
                    count++;
                   
                }
                if (x + 10 == bombNumberarray[i])
                {
                    count++;
                   
                }
                 if (x + 9 == bombNumberarray[i])
                {
                    count++;
                    
                }
                 if (x - 9 == bombNumberarray[i])
                {
                    count++;
                   
                }

                
            }
            Console.WriteLine($"There are {count} bombs near you");

        }

    }
}