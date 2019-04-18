using Roulette.Bets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ThrowBall throwBall = new ThrowBall();
            BetOnNumber bets = new BetOnNumber();
            throwBall.BinNumber(random);
            Console.WriteLine($"Bin number is: {throwBall.number[throwBall.num]}");
            bets.OneZero(throwBall.num);
            bets.DoubleZero(throwBall.num);
            bets.EvenOdds(throwBall.num);
            bets.Color(throwBall.color, throwBall.num);
            bets.HighLows(throwBall.num);
            bets.Dozens(throwBall.num);
            bets.Columns(throwBall.num);
            bets.Row(throwBall.num);
        }
    
    }
}
