using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegerCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                numList.Append(rnd.Next());
            }
            numList.Sort();




        }
    }
}
