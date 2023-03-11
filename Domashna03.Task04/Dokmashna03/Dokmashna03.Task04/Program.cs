Console.WriteLine("Ve molam vnesete go vasiot rodenden");

string inputDate = Console.ReadLine();
double AgeCalculator(string someInputDate)
{
    try
    {
        if (DateTime.TryParse(someInputDate, out DateTime inputDateParsed))
        {
            double age = (DateTime.Now - inputDateParsed).TotalDays / 365;
            return Math.Round(age, 1);
        }
        else
        {
            throw new Exception();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Error, wrong entry!");
    }
    return 0;
}
Console.WriteLine($"Vie imate {AgeCalculator(inputDate)} godini");