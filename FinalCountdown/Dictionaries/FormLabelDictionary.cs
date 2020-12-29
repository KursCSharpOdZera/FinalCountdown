using FinalCountdown.Enums;
using FinalCountdown.Models;
using System.Collections.Generic;

namespace FinalCountdown.Dictionaries
{
    public class FormLabelDictionary
    {
        private static readonly FormLabelDictionary _instance = new FormLabelDictionary();
        private readonly Dictionary<FormLabelName, FormLabel> _dictionary;

        public FormLabelDictionary()
        {
            _dictionary = new Dictionary<FormLabelName, FormLabel>
            {
                { FormLabelName.ProgramHeader,      new ("NEW YEAR COUNTDOWN",              new (0,  0)) },
                { FormLabelName.TimeLeftLabel,      new ("Time remaining until New Year:",  new (0,  4)) },
                { FormLabelName.DaysLeftLabel,      new ("Days:",                           new (1,  5)) },
                { FormLabelName.HoursLeftLabel,     new ("Hours:",                          new (1,  6)) },
                { FormLabelName.MinutesLeftLabel,   new ("Minutes:",                        new (1,  7)) },
                { FormLabelName.SecondsLeftLabel,   new ("Seconds:",                        new (1,  8)) },
                { FormLabelName.EscapeLabel,        new ("Press ESC to quit",               new (0, 10)) }
            };
        }

        public static FormLabelDictionary Instance => _instance;

        public FormLabel this[FormLabelName formLabelName] => _dictionary[formLabelName];
    }
}
