/*
Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
Eg:
seconds = 288970
The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"
Output: 3 days, 8 hours, 16 minutes, 10 seconds
*/

namespace AssignmentTimeCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Input
			int seconds = 288970;

			// Copying the actual input; so that, the original input will be persisted
			int remaining_seconds = seconds; 
			// 1 minute = 60 seconds
			int seconds_per_minute = 60; 
			// 1 hour = 60 minute (each minute is 60 seconds)
			int seconds_per_hour = 60 * 60; 
			// 1 day = 24 hours (each hour is 60 minutes; and each minute is 60 seconds)
			int seconds_per_day = 24 * 60 * 60; 

 			// Divide the "remaining_seconds" with "number of seconds per day"
			int days = remaining_seconds / seconds_per_day;
			// Subtract the number of seconds which equivalent to the number of days calculated above
			remaining_seconds -= days * seconds_per_day; 
			// Divide the "remaining_seconds" with "number of seconds per hour"
			int hours = remaining_seconds / seconds_per_hour; 
			// Subtract the number of seconds which equivalent to the number of hours calculated above
			remaining_seconds -= hours * seconds_per_hour; 
			// Divide the "remaining_seconds" with "number of seconds per minute"
			int minutes = remaining_seconds / seconds_per_minute;
			// Subtract the number of seconds which equivalent to the minutes of days calculated above
			remaining_seconds -= minutes * seconds_per_minute; 

			System.Console.WriteLine(days + " days, " + hours + " hours, " + minutes + " minutes, " + remaining_seconds + " seconds");
			System.Console.ReadKey();
		}
	}
}
