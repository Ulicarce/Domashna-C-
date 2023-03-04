
Console.WriteLine("Enter the first number:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("The first number is larger.");
}
else if (number2 > number1)
{
    Console.WriteLine("The second number is larger.");
}
else
{
    Console.WriteLine("Both numbers are equal.");
}


if (number1 % 2 == 0)
{
    Console.WriteLine("The first number is even.");
}
else
{
    Console.WriteLine("The first number is odd.");
}

if (number2 % 2 == 0)
{
    Console.WriteLine("The second number is even.");
}
else
{
    Console.WriteLine("The second number is odd.");
}

// Write the larger number in the console
if (number1 > number2)
{
    Console.WriteLine("The larger number is: " + number1);
}
else if (number2 > number1)
{
    Console.WriteLine("The larger number is: " + number2);
}
else
{
    Console.WriteLine("Both numbers are equal.");
}
