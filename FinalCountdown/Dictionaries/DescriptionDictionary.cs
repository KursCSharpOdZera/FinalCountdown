using FinalCountdown.Enums;
using FinalCountdown.Helpers;
using System;
using System.Collections.Generic;

namespace FinalCountdown.Dictionaries
{
    public class DescriptionDictionary
    {
        private static readonly DescriptionDictionary _instance = new DescriptionDictionary();
        private readonly Dictionary<DescriptionName, string> _dictionary;

        public DescriptionDictionary()
        {
            _dictionary = new Dictionary<DescriptionName, string>
            {
                { DescriptionName.NotYetNewYearEve, StringHelper.PadLine("There's still much time left.") },
                { DescriptionName.OverOneHour,      StringHelper.PadLine("It's New Year Eve day!") },
                { DescriptionName.OverTenMinutes,   StringHelper.PadLine("There's less than one hour left!") },
                { DescriptionName.OverOneMinute,    StringHelper.PadLine("Less than ten minutes remain!") },
                { DescriptionName.OverTenSeconds,   StringHelper.PadLine("GET READY! It's below one minute left!") },
                { DescriptionName.OverZeroSeconds,  StringHelper.PadLine("FINAL COUNTDOWN!!!") },
                { DescriptionName.NewYear,          StringHelper.PadLine($"HAPPY NEW YEAR { DateTime.Now.Year } !!!") }
            };
        }

        public static DescriptionDictionary Instance => _instance;

        public string this[DescriptionName descriptionName] => _dictionary[descriptionName];
    }
}
