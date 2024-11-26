using System;

class Program91
{
    static void Divi(int []Arr, int iLength)
    {
        int i = 0;

        Console.WriteLine("Numbers divisible by 11 is : ");
        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] % 11 == 0)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
    static void Main(string[] Argv)
    {
        int i = 0;

        Console.WriteLine("How many nujmbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");

        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        Divi(P, iSize);
    }
}