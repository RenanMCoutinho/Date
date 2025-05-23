// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Globalization;

Console.Clear();

var timeSpan = new TimeSpan(5, 12, 00);
Console.WriteLine(timeSpan);



// var data = DateTime.Now;

/*Console.WriteLine(data);
Console.WriteLine(data.Year);
Console.WriteLine(data.Month);
Console.WriteLine(data.Day);
Console.WriteLine(data.Hour);
Console.WriteLine(data.Minute);
Console.WriteLine(data.Second);
Console.WriteLine(data.TimeOfDay);
Console.WriteLine(data.DayOfWeek);*/


var data = DateTime.Now;
var pt = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");
//data local da maquina , servidor.
var atual = CultureInfo.CurrentCulture;

//horario base
var utcDate = DateTime.UtcNow;

var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine(timezoneAustralia);

var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
Console.WriteLine(horaAustralia);

Console.WriteLine("--------------------------------------");

Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime());

Console.WriteLine(data.ToString("D", pt));
Console.WriteLine(data.ToString("D", de));

Console.WriteLine("--------------------------------------");
Console.WriteLine(data);
Console.WriteLine(data.AddDays(-1));
Console.WriteLine(data.AddMonths(12));
Console.WriteLine(data.AddYears(1));

if (data.Date >= DateTime.Now.Date) { Console.WriteLine("é Igual"); } else { Console.WriteLine("Difetente"); }


var timezones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timezones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
    Console.WriteLine("---------------");
}
// Y ou y = ano; M = mes; d = dia; h = hora; s = segundo 
//var formatada = string.Format("{0:dd-MM-yyyy / hh:mm:ss }", data);
//Console.WriteLine(formatada);

//var formatada2 = string.Format("{0:D}", data);
//Console.WriteLine(formatada2);

//var formatada3 = string.Format("{0:f}", data);
//Console.WriteLine(formatada3);

//metodos
Console.WriteLine(DateTime.DaysInMonth(2025, 5));

static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;

}
Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
