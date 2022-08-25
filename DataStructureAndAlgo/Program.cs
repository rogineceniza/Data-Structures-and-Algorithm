using System.Globalization;

string tableNumber = "A100";
int peopleCount = 4;
DateTime reservationDateTime = new DateTime(
2017, 10, 28, 11, 0, 0);
CultureInfo cultureInfo = new CultureInfo("en-US");
Console.WriteLine(
"Table {0} has been booked for {1} people on {2} at {3}",
tableNumber,
peopleCount,
reservationDateTime.ToString("M/d/yyyy", cultureInfo),
reservationDateTime.ToString("HH:mm", cultureInfo));

CultureInfo cInfo = new CultureInfo("en-PH");
Console.WriteLine(cultureInfo.DisplayName);