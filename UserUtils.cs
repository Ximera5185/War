using System;

namespace War
{
    static class UserUtils
    {
        private static Random s_random = new Random();

        static public int GetRandomNumber(int minValue, int maxValue)
        {
            return s_random.Next(minValue, maxValue);
        }

        static public int GetRandomNumber(int value)
        {
            return s_random.Next(value);
        }
    }
}