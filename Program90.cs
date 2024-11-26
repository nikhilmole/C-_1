using System;


class Program90
{
    static void Divi(int []Arr, int iLength)
    {
        int i = 0;
        Console.WriteLine("Number divisible 3 and 5 is : ");
        for(i = 0; i < iLength; i++)
        {
            if((Arr[i] % 3 == 0)&&(Arr[i] % 5 == 0))
            {
                Console.WriteLine(Arr[i]);   
            }
        }
    }
    static void Main(string[] Argv)
    {
        int i = 0;
        int iSize = 0;

        Console.WriteLine("How many numbers you want to add in array : ");
        iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        Divi(P, iSize);
    }
}