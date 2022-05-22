using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizMineSweeper
{
    internal class Mines
    {
        public int Bomb;

        public void GenerateBombs()
        {
            List<int> NumberofBombs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> MinesNumbers = new List<int>();
            Random randNum = new Random();
            for (int i = 0; i < NumberofBombs.Count;)
            {
                int RandomNum = randNum.Next(1, 15);
                if (MinesNumbers.Contains(RandomNum))
                {
                    MinesNumbers.Add(RandomNum);
                    i++;
                }

            }

        }
    }

    
}
