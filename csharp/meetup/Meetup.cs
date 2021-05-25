using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private DateTime dateTime { get; set; }
    public Meetup(int month, int year)
    {
        dateTime = new DateTime(year, month, 1);
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        
        dateTime = schedule switch
        {
            Schedule.Teenth => new DateTime(dateTime.Year, dateTime.Month, 19),
            Schedule.First  => new DateTime(dateTime.Year, dateTime.Month, 7),
            Schedule.Second => new DateTime(dateTime.Year, dateTime.Month, 14),
            Schedule.Third  => new DateTime(dateTime.Year, dateTime.Month, 21),
            Schedule.Fourth => new DateTime(dateTime.Year, dateTime.Month, 28),
            Schedule.Last   => new DateTime(dateTime.Year, dateTime.Month, dateTime.AddMonths(1).AddDays(-1).Day)
        };

        for (int i = dateTime.Day; i >= dateTime.Day - 7; i--)
        {
            dateTime = new DateTime(dateTime.Year, dateTime.Month, i);
            if (dateTime.DayOfWeek == dayOfWeek) break;
        }

        return dateTime;
    }

}