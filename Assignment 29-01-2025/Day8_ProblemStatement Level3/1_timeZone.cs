using System;

class TimeZoneExample
{
    static void Main()
    {
        // Get current UTC time
        DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;

        // Display current time in GMT (Greenwich Mean Time)
        TimeZoneInfo gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentUtcTime, gmtTimeZone);
        Console.WriteLine("Current time in GMT: " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Display current time in IST (Indian Standard Time)
        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentUtcTime, istTimeZone);
        Console.WriteLine("Current time in IST: " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Display current time in PST (Pacific Standard Time)
        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentUtcTime, pstTimeZone);
        Console.WriteLine("Current time in PST: " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
