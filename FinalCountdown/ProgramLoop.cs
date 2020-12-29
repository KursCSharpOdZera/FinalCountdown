using System;
using System.Threading;

namespace FinalCountdown
{
    public class ProgramLoop
    {
        private const int OneSecond = 1000;

        private readonly ClockView _clockView;
        private bool _programLoopStop = false;

        public ProgramLoop(ClockView clockView)
        {
            _clockView = clockView;
        }

        public void Run()
        {
            do
            {
                _clockView.Update();
                CaptureEscButton();
                Thread.Sleep(OneSecond);
            } while (_programLoopStop == false);
        }

        private void CaptureEscButton()
        {
            if (Console.KeyAvailable)
            {
                _programLoopStop = Console
                    .ReadKey(intercept: true)
                    .Key == ConsoleKey.Escape;
            }
        }
    }
}
