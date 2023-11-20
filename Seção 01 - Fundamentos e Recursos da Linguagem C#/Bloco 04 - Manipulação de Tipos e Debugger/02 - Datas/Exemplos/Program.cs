using System.Globalization;

var fullDate = new DateTime(2023, 11, 20, 16, 58, 0);
var date = fullDate.ToShortDateString();
var day = fullDate.Day;
var now = fullDate.ToShortTimeString();
var weekDay = fullDate.ToString("dddd", new CultureInfo("pt-br"));
var year = fullDate.Year;
Console.WriteLine($"Data completa: {fullDate}.\nData: {date}.\nDia: {day}.\nHora: {now}.\nDia da semana: {weekDay}.\nAno: {year}");

static string GetTimeNow()
{
    return $"\nAgora são: {DateTime.Now.ToShortTimeString()}.";
}

static string DaysToAdd(int days)
{
    var today = DateTime.Now;
    var daysToAdd = new TimeSpan(days, 0, 0, 0);
    var result = today.Add(daysToAdd);

    string message1 = $"Hoje é {today.Day}/{today.Month}, {today.ToString("dddd", new CultureInfo("pt-br"))}.";
    string message2 = $"Daqui a 36 dias será {result.Day}/{result.Month}, {result.ToString("dddd", new CultureInfo("pt-br"))}.";

    return $"\n{message1}\n{message2}";
}

static string DaysToSubtract(int days)
{
    var today = DateTime.Now;
    var daysToAdd = new TimeSpan(-days, 0, 0, 0);
    var result = today.Add(daysToAdd);

    string message1 = $"Hoje é {today.Day}/{today.Month}, {today.ToString("dddd", new CultureInfo("pt-br"))}.";
    string message2 = $"Há 36 dias era {result.Day}/{result.Month}, {result.ToString("dddd", new CultureInfo("pt-br"))}.";

    return $"\n{message1}\n{message2}";
}

Console.WriteLine(GetTimeNow());
Console.WriteLine(DaysToAdd(36));
Console.WriteLine(DaysToSubtract(41));

var date1 = new DateTime(2023, 9, 1, 5, 0, 0);
var date2 = new DateTime(2022, 8, 10, 12, 0, 0);

static string CompareDates(DateTime date1, DateTime date2)
{
    int result = DateTime.Compare(date1, date2);
    string relationship;

    if (result < 0) relationship = "é anterior à";
    else if (result == 0) relationship = "é o mesmo que";
    else relationship = "é posterior à";

    return $"\nA data {date1.ToShortDateString()} {relationship} {date2.ToShortDateString()}.";
}

Console.WriteLine(CompareDates(date1, date2));

var date3 = new DateTime(2014, 1, 25, 19, 0, 0);
Console.WriteLine($"\n(Format \"dddd\") => A data é {date3.ToString("dddd", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"d\") => A data é {date3.ToString("d", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"D\") => A data é {date3.ToString("D", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"f\") => A data é {date3.ToString("f", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"F\") => A data é {date3.ToString("F", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"g\") => A data é {date3.ToString("g", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"m\") => A data é {date3.ToString("m", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"o\") => A data é {date3.ToString("o", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"R\") => A data é {date3.ToString("R", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"s\") => A data é {date3.ToString("s", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"t\") => A data é {date3.ToString("t", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"T\") => A data é {date3.ToString("T", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"u\") => A data é {date3.ToString("u", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"U\") => A data é {date3.ToString("U", new CultureInfo("pt-br"))}.");
Console.WriteLine($"(Format \"y\") => A data é {date3.ToString("y", new CultureInfo("pt-br"))}.");
