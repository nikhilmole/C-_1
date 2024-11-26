using System;

class Program97
{
    static bool Search(int []Arr, int iLength, int iNum)
    {
        int i = 0;
        bool bFlag = false;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] == iNum)
            {
                bFlag = true;
                break;
            }
        }
        return bFlag;
    }
    static void Main(String[] Argv)
    {
        int i = 0;
        bool bRet = false;

        Console.WriteLine("How many numbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");

        for(i = 0; i < iSize; i ++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the number you want to search : ");
        int iNo = int.Parse(Console.ReadLine());

        bRet = Search(P, iSize, iNo);

        if(bRet == true)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}