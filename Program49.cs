using System;

class Program45
{
    static int OddFreq(int iNum)
    {
        int iDigit = 0;
        int Freq = 0;
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        while(iNum > 0)
        {
            iDigit = iNum % 10;
            if(iDigit % 2 != 0)
            {
                Freq++;
            }
            iNum = iNum / 10;
        }
        return Freq;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

       int iRet =  OddFreq(iNo);
       Console.WriteLine(iRet);
    }
}