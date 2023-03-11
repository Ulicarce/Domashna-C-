Console.WriteLine();
Console.WriteLine("Ve molam vnesete rechenica:");
string inputSentence = Console.ReadLine();
string[] sentenceWords = inputSentence.Split(" ");
Console.WriteLine("Vashata rechenica e:");
foreach (string word in sentenceWords)
{
    Console.WriteLine($"{word} ");
}
