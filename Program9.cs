using System;

class Program9
{
    bool DivisibleOrNot(int iNum)
    {

        if(iNum % 5 == 0)
        {
            return true;
        }
        return false;   
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;

        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program9 pobj = new Program9();

        bRet = pobj.DivisibleOrNot(iNo);

        if(bRet == true)
        {
            Console.WriteLine("The number is Divisible");
        }
        else
        {
            Console.WriteLine("The number is not divisiblle");
        }
    }
}