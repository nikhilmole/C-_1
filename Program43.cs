using System;

class Program43
{
    static void DisplayDig(int iNum)
    {
        int iDigit = 0;

        if(iNum < 0)
        {
            iNum = -iNum;
        }

        while(iNum > 0)
        {
            iDigit = iNum % 10;
            Console.WriteLine(iDigit);
            iNum = iNum / 10;
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        DisplayDig(iNo);
    }
}