using System;

class Program96
{
    static int Freq(int []Arr, int iLength, int iNum)
    {
        int i = 0;
        int iCnt = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] == iNum)
            {
                iCnt++;
            }
        }
        return iCnt;
    }
    static void Main(String[] Argv)
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

        Console.WriteLine("Enter the number you want to count frequency : ");
        int iNo = int.Parse(Console.ReadLine());
        
        int iRet = Freq(P, iSize, iNo);
        Console.WriteLine(iRet);
    }
}