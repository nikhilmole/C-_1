using System;


class Program12
{
    bool CheckEvenOdd(int iNum)
    {
        if((iNum % 2) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program12 pobj = new Program12();

        bRet = pobj.CheckEvenOdd(iNo);

        if(bRet == true)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("the number is odd");
        }
    }
}