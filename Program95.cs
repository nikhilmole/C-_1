using System;

class Program95
{
    static int Freq(int []Arr, int iLength)
    {
        int iCnt = 0;
        int i = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] == 11)
            {
                iCnt++;
            }
        }
        return iCnt;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("How many numbers you want to add : ");
        int iSize = int.Parse(Console.ReadLine());

        int i = 0;

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        int iRet = Freq(P, iSize);
        Console.WriteLine("11 Frequency is : {0}",iRet);
    }
}