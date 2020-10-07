using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetRandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}
