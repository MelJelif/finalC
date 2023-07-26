using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of strings in the array:");
        int n = int.Parse(Console.ReadLine());

        string[] originalArray = new string[n];
        Console.WriteLine("Enter the strings:");

        for (int i = 0; i < n; i++)
        {
            originalArray[i] = Console.ReadLine();
        }

        string[] newArray = new string[0];

        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                Array.Resize(ref newArray, newArray.Length + 1);
                newArray[newArray.Length - 1] = originalArray[i];
            }
        }

        Console.WriteLine("New array of strings with length <= 3:");

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
