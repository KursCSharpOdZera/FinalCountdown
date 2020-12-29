using FinalCountdown.Dictionaries;
using FinalCountdown.Enums;
using FinalCountdown.Helpers;
using System;

namespace FinalCountdown
{
    public class ClockView
    {
        private Clock _clock;
        FormLabelDictionary _formLabels = FormLabelDictionary.Instance;
        FormFieldCursorPositionDictionary _formFieldCursorPositions = FormFieldCursorPositionDictionary.Instance;

        public ClockView()
        {
            ConsoleHelper.PrepareConsole();
            PrepareRawForm();
        }

        public void Update()
        {
            _clock = new Clock();
            UpdateNumbers();
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

        private void UpdateNumbers()
        {
            ConsoleHelper.WriteAtCursorPosition
                (
                    text:           StringHelper.PadNumber(_clock.DaysLeft),
                    cursorPosition: _formFieldCursorPositions[FormFieldName.DaysLeftCount]
                );
            ConsoleHelper.WriteAtCursorPosition
                (
                    text:           StringHelper.PadNumber(_clock.HoursLeft),
                    cursorPosition: _formFieldCursorPositions[FormFieldName.HourseftCount]
                );
            ConsoleHelper.WriteAtCursorPosition
                (
                    text:           StringHelper.PadNumber(_clock.MinutesLeft),
                    cursorPosition: _formFieldCursorPositions[FormFieldName.MinutesLeftCount]
                );
            ConsoleHelper.WriteAtCursorPosition
                (
                    text:           StringHelper.PadNumber(_clock.SecondsLeft),
                    cursorPosition: _formFieldCursorPositions[FormFieldName.SecondsLeftCount]
                );
        }
    }
}
