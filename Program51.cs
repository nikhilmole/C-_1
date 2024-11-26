using System;

class Program45
{
    static int MultiDigi(int iNum)
    {
        int iDigit = 0;
        int Freq = 0;
        int iMulti = 1;
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        while(iNum > 0)
        {
            iDigit = iNum % 10;
            iMulti = iMulti * iDigit;
            iNum = iNum / 10;
        }
        return iMulti;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

       int iRet =  MultiDigi(iNo);
       Console.WriteLine(iRet);
    }
}