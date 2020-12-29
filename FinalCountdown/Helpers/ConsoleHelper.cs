using static System.Console;

namespace FinalCountdown.Helpers
{
    public static class ConsoleHelper
    {
        public static void PrepareConsole()
        {
            Clear();
            CursorVisible = false;
        }
    }
}
