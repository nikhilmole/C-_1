using System;

class Program43
{
    static bool DisplayDig(int iNum)
    {
        int iDigit = 0;
        bool bFlag = false;
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        while(iNum > 0)
        {
            iDigit = iNum % 10;
            iNum = iNum / 10;

            if(iDigit == 0)
            {
                bFlag = true;
            }
        }
        return bFlag;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        bool bRet = DisplayDig(iNo);

        if(bRet == true)
        {
            Console.WriteLine("Zero avalilble");
        }
        else
        {
            Console.WriteLine("Zero not avalilble");
        }
    }
}