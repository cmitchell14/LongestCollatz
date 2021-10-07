using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The following iterative sequence is defined for the set of positive integers:

            n → n/2 (n is even)
            n → 3n + 1 (n is odd)

            Using the rule above and starting with 13, we generate the following sequence:
            13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

            It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it
            has not been proven yet (Collatz Problem), it is thought that all starting numbers finish at 1.

            Which starting number, under one thousand, produces the longest chain?

            NOTE: Once the chain starts the terms are allowed to go above one thousand*/

            int count = 1;
            int seq;
            Dictionary<int, int> chains = new Dictionary<int, int>() { };

            for (int i = 1; i <= 999; i++)
            {
                seq = i; //Starting sequence from correct spot.
                count = 1;  //Reset Counter.

                while (seq != 1)
                {
                    if (seq % 2 == 0)
                    {
                        seq = seq / 2;
                        //Console.WriteLine(seq); --> Used for testing
                        count++;
                    }
                    else
                    {
                        seq = (seq * 3) + 1;
                        //Console.WriteLine(seq); --> Used for testing
                        count++;
                    }
                }

                chains.Add(i, count);
                //Console.WriteLine($"\n\nTotal in Sequence: {i} : {count}"); --> Used for testing.

            }
            var maxValue = chains.Values.Max();
            var keyOfMaxValue = chains.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine($"\n\nThe number with the largest chain is: {keyOfMaxValue} with a chain of {maxValue}");


        }
    }
}
