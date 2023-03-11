//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int[] numbers = new int[6];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write($"Enter integer no.{i + 1}: ");
//            numbers[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;
//        foreach (int number in numbers)
//            if (number > 0)
//            {
//            if (number % 2 == 0)
//                sum += number;
//        }
//    else
//        {
//            Console.WriteLine("Ve molam vnesete broevi!");
//        }

//        Console.WriteLine($"The result is: {sum}");

//    }
//}

Console.WriteLine("Student Group");


string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
        string[] studentsG2 = new string[] { "Ana", "Maja", "Sara", "Ivana", "Jana" };

       
        Console.WriteLine("Enter student group (1 or 2):");
        string groupNumber = Console.ReadLine();

    
    if (groupNumber == "1")
        {
            Console.WriteLine("The students in G1 are:");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            }
        }
        else if (groupNumber == "2")
        {
            Console.WriteLine("The students in G2 are:");
            foreach (string student in studentsG2)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("Invalid group number.");
        }
    