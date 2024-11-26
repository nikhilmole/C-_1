using System;

class Program89
{   
    static void EvenDivisible(int []Arr, int iLength)
    {
        int i = 0;

        Console.WriteLine("Even and divisible by 5 numbers are : ");
        for(i = 0; i < iLength; i++)
        {
            if((Arr[i] % 5 == 0) && (Arr[i] % 2 == 0))
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
    static void Main(string[] Argv)
    {
        int i = 0;
        Console.WriteLine("How many numbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        EvenDivisible(P,iSize);

    }
}