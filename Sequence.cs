using System;

namespace NumberSequenceApp
{
    public class Sequence
    {
        public void PrintSequence(int numberCount)
        {
            int prev1 = 0;
            int prev2 = 1;
            int current;

            Console.WriteLine(prev1);
            Console.WriteLine(prev2);

            for (int i = 3; i <= numberCount; i++)
            {
                current = prev1 + prev2;
                Console.WriteLine(current);

                prev1 = prev2;
                prev2 = current;
            }
        }
    }
}