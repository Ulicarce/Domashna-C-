Console.WriteLine("Vnesete podatok:");
string input = Console.ReadLine();

if (input.Length >= 5)
{
    string lastFive = input.Substring(input.Length - 5);
    Console.WriteLine("Posledni 5 karakteri se: " + lastFive);
}
else
{
    Console.WriteLine("Vnesovte pomalku od 5karakteri!");
}