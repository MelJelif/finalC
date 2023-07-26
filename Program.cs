using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of strings in the array:");
        int n = int.Parse(Console.ReadLine());
        
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
        
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
