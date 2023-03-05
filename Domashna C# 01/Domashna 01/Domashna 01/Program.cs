//Console.WriteLine("===Real Calculator===");
//Console.WriteLine("Enter first number:");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//double num2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Choose an operation(+,-,*,/):");
//string operation = Console.ReadLine();
//double result = 0;
//switch(operation)
//{
// case "+":
//result = num1 + num2;
// break;
// case "-":
// result = num1 - num2;
/// break;  
// case "*":
// result = num1 * num2;
//break;
// case "/":
// result = num1 / num2;
// break;
// default: Console.WriteLine("Invalid operation input.");
// break;}
//Console.WriteLine("Result:" + result);


//Console.WriteLine("===Average Number===");
//double number1, number2, number3, number4;

//Console.Write("Enter the First number: ");
//number1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the Second number: ");
//number2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the third number: ");
//number3 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the fourth number: ");
//number4 = Convert.ToDouble(Console.ReadLine());

//double result = (number1 + number2 + number3 + number4) / 4;
//Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
//number1, number2, number3, number4, result);


Console.WriteLine("===SwapNumbers===");
int number1, number2, temp;
Console.Write("Input the First Number : ");
number1 = int.Parse(Console.ReadLine());
Console.Write("Input the Second Number : ");
number2 = int.Parse(Console.ReadLine());
temp = number1;
number1 = number2;
number2 = temp;
Console.Write("After Swapping : ");
Console.Write("\nFirst Number : " + number1);
Console.Write("\nSecond Number : " + number2);
Console.Read();