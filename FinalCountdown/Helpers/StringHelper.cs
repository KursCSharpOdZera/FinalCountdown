namespace FinalCountdown.Helpers
{
    public static class StringHelper
    {
        public static string PadNumber(int number) =>
            number.ToString().PadLeft(2);
    }
}
