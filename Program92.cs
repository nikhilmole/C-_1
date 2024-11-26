using System;

class Program92
{   
    static int CountEven(int []Arr, int iLength)
    {
        int i = 0;
        int iCnt = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] % 2 == 0)
            {
                iCnt++;
            }
        }
        return iCnt;
    }
    static void Main(string[] Argv)
    {
        int i = 0;
        Console.WriteLine("How many numbers you wawnt to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        int iRet = CountEven(P, iSize);
        Console.WriteLine("Even number count : "+iRet);
    }
}