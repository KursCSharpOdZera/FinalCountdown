using FinalCountdown.Enums;
using FinalCountdown.Models;
using System.Collections.Generic;

namespace FinalCountdown.Dictionaries
{
    public class FormFieldCursorPositionDictionary
    {
        private static readonly FormFieldCursorPositionDictionary _instance = new FormFieldCursorPositionDictionary();
        private readonly Dictionary<FormFieldName, CursorPosition> _dictionary;

        public FormFieldCursorPositionDictionary()
        {
            _dictionary = new Dictionary<FormFieldName, CursorPosition>
            {
                { FormFieldName.NewYearLabel,       new ( 0, 2) },
                { FormFieldName.DaysLeftCount,      new (11, 5) },
                { FormFieldName.HourseftCount,      new (11, 6) },
                { FormFieldName.MinutesLeftCount,   new (11, 7) },
                { FormFieldName.SecondsLeftCount,   new (11, 8) }
            };
        }

        public static FormFieldCursorPositionDictionary Instance => _instance;

        public CursorPosition this[FormFieldName formFieldName] => _dictionary[formFieldName];
    }
}
