using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.Bets
{
    class BetOnNumber
    {
        public void OneZero(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Bin 0 wins");
            }
            return;
        }

        public void DoubleZero(int num)
        {
            if (num == 37)
            {
                Console.WriteLine("Bin 00 wins");
            }
            return;
        }

        public void EvenOdds(int num)
        {
            if (num == 0 || num == 37)
            {
                return;
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("Odds win");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("Evens win");
            }
            return;
        }

        public void Color(string[] color, int num)
        {
            Console.WriteLine(color[num] + " wins");
        }

        public void HighLows(int num)
        {
            if (num >= 1 && num <= 18)
            {
                Console.WriteLine("Lows win");
            }
            else if (num >= 19 && num <= 36)
            {
                Console.WriteLine("Highs win");
            }
            return;
        }

        public void Dozens(int num)
        {
            if (num >= 1 && num <= 12)
            {
                Console.WriteLine("1st 12 win");
            }
            else if (num >= 13 && num <= 24)
            {
                Console.WriteLine("2nd 12 win");
            }
            else if (num >= 25 && num <= 36)
            {
                Console.WriteLine("3rd 12 wins");
            }
            return;
        }

        public void Columns(int num)
        {
            if (num == 0 || num == 37)
            {
                return;
            }
            else if (num == 1 || num % 3 == 1)
            {
                Console.WriteLine("1st column wins");
            }
            else if (num == 2 || num % 3 == 2)
            {
                Console.WriteLine("2nd column wins");
            }
            else Console.WriteLine("3rd column wins");
        }

        public void Row(int num)
        {
            if (num == 0 || num == 37)
            {
                return;
            }
            else if (num == 1 ||num % 3 == 1)
            {
                Console.WriteLine($"Row {num} through {num + 2} wins");
            }
            else if (num == 2 || num % 3 == 2)
            {
                Console.WriteLine($"Row {num - 1} through {num + 1} wins");
            }
            else Console.WriteLine($"Row {num - 2} through {num} wins");
            return;
        }

        //public void Sixes(int num)
        //{
        //    if (num == 0 || num == 37)
        //    {
        //        return;
        //    }
        //    else if (num % 3 == 1)
        //    {
        //        Console.WriteLine($"Row {num} through {num + 2} wins");
        //    }
        //    else if (num % 3 == 2)
        //    {
        //        Console.WriteLine($"Row {num - 1} through {num + 1} wins");
        //    }
        //    else Console.WriteLine($"Row {num - 2} through {num} wins");
        //    return;
        //}


    }
}
