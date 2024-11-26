using System;

class Program94
{
    static bool Search(int []Arr, int iLength)
    {
        bool bFlag = false;
        int i = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] == 11)
            {
                bFlag = true;
                break;
            }
        }
        return bFlag;
    }
    static void Main(string[] Argv) 
    {
        int i = 0;
        bool bRet = false;

        Console.WriteLine("How many numbers you want to add : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");

        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        bRet = Search(P, iSize);
        if(bRet == true)
        {
            Console.WriteLine("11 is present");
        }
        else
        {
            Console.WriteLine("11 is not present");
        }
    }
}