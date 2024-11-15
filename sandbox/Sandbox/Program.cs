using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine($"Today is {today}");
        Console.WriteLine(today.GetType());
// DateTime currentDateTime = DateTime.Now; 
		// DateTime todaysDate = DateTime.Today;
        // DateTime dateOnly = todaysDate.Date; 
		// // DateTime currentDateTimeUTC = DateTime.UtcNow; 
		
		// // DateTime maxDateTimeValue = DateTime.MaxValue; 
		// // DateTime minDateTimeValue = DateTime.MinValue;

        // string today = $"{dateOnly}";
		
		// // Console.WriteLine($"Current DateTime {currentDateTime}");
		// Console.WriteLine($"Today's Date {today}");
		// // Console.WriteLine($"Current DateTime UTC Timezone {currentDateTimeUTC}");
		// Console.WriteLine($"Max DateTime Value {maxDateTimeValue}");
		// Console.WriteLine($"Min DateTime Value {minDateTimeValue}");
    }
}