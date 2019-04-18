using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class ThrowBall
    {
        public string[] number= new string []  {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14",
                "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32",
                "33", "34", "35", "36", "00"};
        public string[] color = new string [] {"Green", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red",
                "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Red", "Black", "Red", "Black",
                "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black",
                "Red", "Green"};
        public int num;

        public void BinNumber(Random rng)
        {
            num = rng.Next(0, 38);
            return;
        }
    }

}

