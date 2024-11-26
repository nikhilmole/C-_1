using System;

class Program5
{
    static void Main(string[] args)
    {
        int iNo = 0;
        Console.WriteLine("Enter the number: ");
        iNo = int.Parse(Console.ReadLine());

        for (int i = 1; i <= iNo; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even number: " + i);
            }
        }
    }
}
