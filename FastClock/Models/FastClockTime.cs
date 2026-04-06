namespace FastClock.Models;

public class FastClockTime
{
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }

    public FastClockTime(int hh, int mm, int ss)
    {
        Hour = hh;
        Minute = mm;
        Second = ss;
    }

    public void Tick()
    {
        Second++;
        if (Second >= 60) { Second = 0; Minute++; }
        if (Minute >= 60) { Minute = 0; Hour++; }
        if (Hour >= 24) { Hour = 0; }
    }

    public string TimeIncSec() =>
        $"{Hour:D2}:{Minute:D2}:{Second:D2}";

    public string TimeExSec() =>
        $"{Hour:D2}:{Minute:D2}";
}
