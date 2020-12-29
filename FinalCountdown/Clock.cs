using System;

namespace FinalCountdown
{
    public class Clock
    {
        private readonly TimeSpan _timeLeft;

        public Clock()
        {
            var nextFirstJanuaryMidnight = new DateTime
                (
                    year:   DateTime.Now.Year + 1,
                    month:  1,
                    day:    1,
                    hour:   0,
                    minute: 0,
                    second: 0
                );

            _timeLeft = nextFirstJanuaryMidnight.Subtract(DateTime.Now);
        }

        public int DaysLeft => _timeLeft.Days;
        public int HoursLeft => _timeLeft.Hours;
        public int MinutesLeft => _timeLeft.Minutes;
        public int SecondsLeft => _timeLeft.Seconds;
        public double TotalSecondsLeft => _timeLeft.TotalSeconds;
    }
}
