using System;

class Program40
{
    static int RangeAdd(int iNum1, int iNum2)
    {
        int iAns = 0;

        if (iNum1 > iNum2)
        {
            Console.WriteLine("Invalid range. The first number must be less than or equal to the second number.");
            return 0; // Return 0 or handle the invalid range appropriately
        }

        for (int i = iNum1; i <= iNum2; i++)
        {
            iAns += i;
        }
        return iAns;
    }

    static void Main(string[] Argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;

        Console.WriteLine("Enter first number: ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        iNo2 = int.Parse(Console.ReadLine());

        int iRet = RangeAdd(iNo1, iNo2);

        if (iNo1 <= iNo2) 
        {
            Console.WriteLine("The sum of numbers in the range is: {0}", iRet);
        }
    }
}
