using FinalCountdown.Dictionaries;
using FinalCountdown.Enums;

namespace FinalCountdown
{
    public static class DescriptionCalculator
    {
        private const int Days364       = 60 * 60 * 24 * 364;
        private const int OneDay        = 60 * 60 * 24;
        private const int OneHour       = 60 * 60;
        private const int TenMinutes    = 60 * 10;
        private const int OneMinute     = 60;
        private const int TenSeconds    = 10;
        private const int ZeroSeconds   = 0;

        private static readonly DescriptionDictionary _descriptions = DescriptionDictionary.Instance;

        public static string Calculate(Clock clock) =>
            clock.TotalSecondsLeft switch
            {
                > Days364       => _descriptions[DescriptionName.NewYear],
                > OneDay        => _descriptions[DescriptionName.NotYetNewYearEve],
                > OneHour       => _descriptions[DescriptionName.OverOneHour],
                > TenMinutes    => _descriptions[DescriptionName.OverTenMinutes],
                > OneMinute     => _descriptions[DescriptionName.OverOneMinute],
                > TenSeconds    => _descriptions[DescriptionName.OverTenSeconds],
                > ZeroSeconds   => _descriptions[DescriptionName.OverZeroSeconds],
                _               => string.Empty
            };
    }
}
