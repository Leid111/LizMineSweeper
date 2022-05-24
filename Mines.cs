using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizMineSweeper
{
    internal class Mines
    {
        public List<int> NumberofBombs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public List<int> MinesNumbers = new List<int>();
        List<int> TotalUserGuesses = new List<int>();
        public int Count;
      
        public void GenerateBombs()
        {

            Random randNum = new Random();
            for (int j = 0; j < NumberofBombs.Count;)
            {
                int RandomNum = randNum.Next(1, 101);
                if (!MinesNumbers.Contains(RandomNum))
                {
                    MinesNumbers.Add(RandomNum);
                    j++;
                }
            }


        }

        public bool CheckUserGuess(int UserGuess)
        {
            return
            !(UserGuess == MinesNumbers[0])
                && !(UserGuess == MinesNumbers[1])
                && !(UserGuess == MinesNumbers[2])
                && !(UserGuess == MinesNumbers[3])
                && !(UserGuess == MinesNumbers[4])
                && !(UserGuess == MinesNumbers[5])
                && !(UserGuess == MinesNumbers[6])
                && !(UserGuess == MinesNumbers[7])
                && !(UserGuess == MinesNumbers[8])
                && !(UserGuess == MinesNumbers[9]);


        }

        public void CheckIfUserGuessIsBomb(int UserGuess, int count = 0)
        {
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

                if (UserGuess - 1 == MinesNumbers[i])
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

            if ((count > 0 && count <= 8)
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
                {
                    Console.WriteLine($"There are {count} bombs near you");
                }
                    



        }

        public void AddValidGuessToTotalGuesses(int UserGuess)
        {
            if (UserGuess >= 0 && UserGuess <= 100 && !(TotalUserGuesses.Contains(UserGuess)))
            {
                TotalUserGuesses.Add(UserGuess);
            }
        }



        public bool CheckIfTheyAreAWinner()
        {
            return (TotalUserGuesses.Count == 90
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
            );
      
        }


    }

    
}
