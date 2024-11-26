using System;

class Program88
{
    static void Divisible(int []Arr, int iLength)
    {
        int i = 0;

        Console.WriteLine("Divisible by 5 numbers are : ");
        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] % 5 == 0)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("How many number you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");
        int i = 0;
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        Divisible(P, iSize);
    }
}