Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================ Working With Dates ================\n\n");
Console.ResetColor();

#region Creating DateTime

// Empty DateTime
DateTime emptyDate = new DateTime();
Console.WriteLine(emptyDate);

// Custom date
DateTime customDate = new DateTime(1994, 10, 23, 19, 20, 30);
Console.WriteLine(customDate);

// DateTime with the current Date
DateTime currentDate = DateTime.Today;
Console.WriteLine(currentDate);

// DateTime with the current Date and Time
DateTime currentDateTime = DateTime.Now;
Console.WriteLine(currentDateTime);
Console.WriteLine(DateTime.UtcNow);

#endregion

#region Parsing

// => Converting from string to DateTime
// => Variations:
// string stringDate="12.15.2012";
// string stringDate="12/15/2012 11:14:34";
// string stringDate="12/15/12";
// string stringDate="dec.15.12";
string stringDate = "12-15-2024 12:34:24";
DateTime.TryParse(stringDate, out DateTime parsedDateTime);
Console.WriteLine(parsedDateTime);


#endregion

#region DateTime Properties

DateTime currentDateAndTime = DateTime.Now;
int month = currentDateAndTime.Month;
Console.WriteLine(month);
Console.WriteLine(currentDateAndTime.Day);
Console.WriteLine(currentDateAndTime.Year);

Console.WriteLine(currentDateAndTime.Ticks);
Console.WriteLine(currentDateAndTime.DayOfWeek);
Console.WriteLine(currentDateAndTime.DayOfYear);

#endregion

#region DateTime Methods

DateTime addedDays = DateTime.Now.AddDays(2);
Console.WriteLine(addedDays);
Console.WriteLine(DateTime.Now.AddDays(-5));

DateTime addedMonths = currentDateAndTime.AddMonths(5);
Console.WriteLine(addedMonths);

DateTime addedYears = currentDateAndTime.AddYears(2);
Console.WriteLine(addedYears);

DateTime addedHours = currentDateAndTime.AddHours(3);
Console.WriteLine(addedHours);

#endregion

#region Formatting Dates

string dateFormat1 = currentDateAndTime.ToString("dd/MM/yyyy");
Console.WriteLine(dateFormat1);

string dateFormat2 = currentDateAndTime.ToString("dd/MM/yyyy HH:mm:ss");
Console.WriteLine(dateFormat2);

string dateFormat3 = currentDateAndTime.ToString("dddd, dd MMMM yyyy");
Console.WriteLine(dateFormat3);

string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}", currentDateAndTime);
Console.WriteLine(dateFormat4);

#endregion

#region Bonus

// Comparing dates
Console.WriteLine(DateTime.Now<DateTime.UtcNow); // False
DateTime dt1 = new DateTime(2025, 9, 24, 14, 30, 0);
DateTime dt2 = new DateTime(2025, 9, 24, 9, 15, 0);
Console.WriteLine(dt1==dt2); // False
// Comparing only the dates (ignoring the time)
Console.WriteLine(dt1.Date==dt2.Date); // True

// *** Calculate time distance between two dates ***
DateTime dateInstance1 = DateTime.UtcNow;
DateTime dateInstance2 = DateTime.UtcNow.AddDays(3).AddHours(5.5);
// TimeSpan => represents a time interval 
TimeSpan timeDifference = dateInstance2 - dateInstance1;
Console.WriteLine($"The time differene between {dateInstance1:MM/dd/yyyy HH:mm:ss} and {dateInstance2:MM/dd/yyyy HH:mm:ss} is exactly {timeDifference.Days} days, {timeDifference.Hours} hours and {timeDifference.Minutes} minutes.");


// *** Other useful methods ***
Console.WriteLine(DateTime.UtcNow.ToShortDateString()); // 3/7/2024
Console.WriteLine(DateTime.UtcNow.ToLongDateString()); // Thursday, March 7, 2024
Console.WriteLine(DateTime.UtcNow.ToShortTimeString()); // 11:30 AM
Console.WriteLine(DateTime.UtcNow.ToLongTimeString()); // 11:30:52 AM
Console.WriteLine(DateTime.UtcNow.ToFileTime()); // 133542846524008581 // used as unique timestamp for some scenarios (for example timestamp in some file name)

// *** DateOnly & TimeOnly ***
DateOnly dateOnly = new DateOnly(2025, 3, 8);
DateOnly currentDateOnly = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Today's date: {currentDateOnly}");

TimeOnly timeOnly = new TimeOnly(14, 30, 0);
TimeOnly currentTimeOnly = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(); Console.WriteLine($"Current time: {currentTimeOnly}");

Console.ReadLine();
#endregion