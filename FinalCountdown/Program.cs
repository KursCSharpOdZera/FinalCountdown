using FinalCountdown;

var clockView = new ClockView();

var programLoop = new ProgramLoop(clockView);
programLoop.Run();
programLoop.ClearAfterRun();
