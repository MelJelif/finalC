using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of strings in the array:");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer value:");
        }

        string[] originalArray = new string[n];
        Console.WriteLine("Enter the strings:");

        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = Console.ReadLine();
        }

        int newSize = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newSize++;
            }
        }

        if (newSize > 0)
        {
            string[] newArray = new string[newSize];
            int index = 0;
            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    newArray[index] = originalArray[i];
                    index++;
                }
            }

            Console.WriteLine("New array of strings with length <= 3:");
            string result = "[" + String.Join(", ", newArray) + "]";

            Console.WriteLine(result);

        }
        else
        {
            Console.WriteLine("No strings found with length <= 3.");
        }
    }
}
