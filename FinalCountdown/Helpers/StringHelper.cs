using System;

namespace FinalCountdown.Helpers
{
    public static class StringHelper
    {
        public static string PadNumber(int number) =>
            number.ToString().PadLeft(2);

        public static string PadLine(string line) =>
            line.PadRight(Console.LargestWindowWidth);
    }
}
