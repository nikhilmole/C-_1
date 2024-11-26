using System;

class Program45
{
    static int SumOddEven(int iNum)
    {
        int iDigit = 0;
        int OddSum = 0;
        int EvenSum = 0;

        if(iNum < 0)
        {
            iNum = -iNum;
        }

        while(iNum > 0)
        {
            iDigit = iNum % 10;
            if(iDigit % 2 == 0)
            {
                EvenSum = EvenSum + iDigit;
            }
            else
            {
                OddSum = OddSum + iDigit;
            }
            iNum = iNum / 10;
        }
        return EvenSum - OddSum;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

       int iRet =  SumOddEven(iNo);
       Console.WriteLine(iRet);
    }
}