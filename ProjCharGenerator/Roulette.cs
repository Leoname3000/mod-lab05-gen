using System;
using System.Linq;

namespace generator
{
    public class Roulette
    {
        public static int Roll(int[] weights, Random random)
        {
            int randVal = random.Next(0, weights.Sum());
            long currentSum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                currentSum += weights[i];
                if (randVal < currentSum)
                {
                    return i;
                }
            }
            throw new Exception("RandVal is bigger than weights sum");
        }
    }
}