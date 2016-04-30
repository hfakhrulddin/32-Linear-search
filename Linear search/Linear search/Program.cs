using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4 };
            int target = 4;

            Console.WriteLine(Search(input, target));
            Console.ReadLine();
        }

        public static bool Search(int[] input, int target)
        {
            for (int i = 0; i < input.Length ; i++)
            {
                if (input[i] == target)
                    return true;
            }
            return false;
        }
    }
}
