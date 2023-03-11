Console.WriteLine("Ve molam vnesete broj:");
bool NumberParsed = int.TryParse(Console.ReadLine(), out int NumbersParsed);
if (NumberParsed)
{
    Console.WriteLine($"Zbirot e: {SumOfDigits(NumbersParsed)}");
}
else
{
    Console.WriteLine("Greshka, Ve molam vnesete broj!");
}
int SumOfDigits(int inputNumber)
{
    int sumOfDigits = 0;
    while (inputNumber > 0)
    {
        sumOfDigits += inputNumber % 10;
        inputNumber /= 10;
    }
    return sumOfDigits;
}
