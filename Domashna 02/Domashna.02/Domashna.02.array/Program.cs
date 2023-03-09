

Console.WriteLine("Excercise 4");

string[] words = { "TV", "Phone", "PS4", "PC", "Tablet" };
decimal[] decimals = { 2.5m, 7.3m, 1.8m, 4.6m, 9.2m };
char[] characters = { 'a', 'b', 'c', 'd', 'e' };
bool[] bools = { true, false, false, true, true };
int[][] numberArrays = new int[5][];
numberArrays[0] = new int[] { 1, 2 };
numberArrays[1] = new int[] { 3, 4 };
numberArrays[2] = new int[] { 5, 6 };
numberArrays[3] = new int[] { 7, 8 };
numberArrays[4] = new int[] { 9, 10 };
foreach (string arrayItem in words)
{
   Console.WriteLine(arrayItem);
};
foreach (decimal arrayItem in decimals)
{
   Console.WriteLine(arrayItem);
};
foreach (char arrayItem in characters)
{
    Console.WriteLine(arrayItem);
};
foreach (bool arrayItem in bools)
{
    Console.WriteLine(arrayItem);
};

foreach (int arrayItem in numberArrays[0])
{
    Console.WriteLine(arrayItem);
};
foreach (int arrayItem in numberArrays[1])
{
    Console.WriteLine(arrayItem);
};

foreach (int arrayItem in numberArrays[2])
{
    Console.WriteLine(arrayItem);
};

foreach (int arrayItem in numberArrays[3])
{
    Console.WriteLine(arrayItem);
};
foreach (int arrayItem in numberArrays[4])
{
    Console.WriteLine(arrayItem);
};

// kako bese da se ispechati da mi ja pokaze cela niza a ne samo edna po edna?



Console.WriteLine("Excercise 5");

int[] intArray = new int[5];
int sumOfArray = 0;
Console.WriteLine("Vnesete 5 broevi:");
for (int i = 0; i < intArray.Length; i++)
{
    bool isParsedToInt = int.TryParse(Console.ReadLine(), out int inputValue);
    if (isParsedToInt)
    {
        intArray[i] = inputValue;
        sumOfArray += inputValue;
    }
    else
    {
        Console.WriteLine("Greshka! Ve molam vnesete broevi");
        i--;
    };
}
Console.WriteLine($"Sumata od nizata e: {sumOfArray}");


Console.WriteLine("Excercise 6");
string[] namesArray = new string[1];
Console.WriteLine("Ve molam vnesete ime:");
namesArray[0] = Console.ReadLine();

for (; ; )
{
    Console.WriteLine("Dali sakate da vnesete drugo ime? Y/N");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        Array.Resize(ref namesArray, namesArray.Length + 1);
        Console.WriteLine("Ve molam vnesete ime:");
        namesArray[namesArray.Length - 1] = Console.ReadLine();
    }
    else if (answer == "N" || answer == "n")
    {
        foreach (string name in namesArray)
        {
            Console.WriteLine("Site vashi iminja se:");
            Console.WriteLine(name);
        }
        break;
    }
    else  Console.WriteLine("Greshka! Ve molam vnesete Y/N (da ili ne)"); }