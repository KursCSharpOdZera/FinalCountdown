using FinalCountdown.Models;
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

        public static void SetCursor(CursorPosition cursorPosition)
        {
            SetCursorPosition(cursorPosition.X, cursorPosition.Y);
        }

        public static void WriteAtCursorPosition(string text, CursorPosition cursorPosition)
        {
            SetCursor(cursorPosition);
            Write(text);
        }
    }
}
