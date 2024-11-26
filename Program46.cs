using System;

class Program45
{
    static int DisplayDig(int iNum)
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
            iNum = iNum / 10;
            if(iDigit == 4)
            {
                Freq++;
            }
        }
        return Freq;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

       int iRet =  DisplayDig(iNo);
       Console.WriteLine(iRet);
    }
}