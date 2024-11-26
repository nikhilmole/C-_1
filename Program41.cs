
using System;

class Program41
{
    static int EvenAdd(int iNum1, int iNum2)
    {
        int Ans = 0;
        int i = 0;

        if(iNum1 > iNum2)
        {
            Console.WriteLine("Invalid Option");
        }
        for(i = iNum1; i <= iNum2; i++)
        {
            if(i % 2 == 0)
            {
                Ans = Ans + i;
            }
        }
        return Ans;
    }

    static void Main(string[] Argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;

        Console.WriteLine("Enter the first number  :");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Second number  :");
        iNo2 = int.Parse(Console.ReadLine());

        int iRet = EvenAdd(iNo1, iNo2);

        if(iNo1 <= iNo2)
        {
            Console.WriteLine(iRet);
        }
    }
}