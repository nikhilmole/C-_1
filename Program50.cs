using System;

class Program45
{
    static int CountRange(int iNum)
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
            if((iDigit > 3) && (iDigit < 7))
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

       int iRet =  CountRange(iNo);
       Console.WriteLine(iRet);
    }
}