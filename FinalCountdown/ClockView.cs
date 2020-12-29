using FinalCountdown.Dictionaries;
using FinalCountdown.Enums;
using FinalCountdown.Helpers;
using System;

namespace FinalCountdown
{
    public class ClockView
    {
        FormLabelDictionary _formLabels = FormLabelDictionary.Instance;

        public ClockView()
        {
            ConsoleHelper.PrepareConsole();
            PrepareRawForm();
        }

        private void PrepareRawForm()
        {
            WriteLabel(FormLabelName.ProgramHeader);
            WriteLabel(FormLabelName.TimeLeftLabel);
            WriteLabel(FormLabelName.DaysLeftLabel);
            WriteLabel(FormLabelName.HoursLeftLabel);
            WriteLabel(FormLabelName.MinutesLeftLabel);
            WriteLabel(FormLabelName.SecondsLeftLabel);
            WriteLabel(FormLabelName.EscapeLabel);
        }

        private void WriteLabel(FormLabelName formLabelName)
        {
            ConsoleHelper.WriteAtCursorPosition
                (
                    text:           _formLabels[formLabelName].Literal,
                    cursorPosition: _formLabels[formLabelName].CursorPosition
                );
        }
    }
}
