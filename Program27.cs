using System;

class Program27
{
    static int Factorial(int iNum)
    {
        int iFacto = 1;

        for (int i = 1; i <= iNum; i++)
        {
            iFacto *= i;
        }
        return iFacto;
    }

    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number:");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = Factorial(iNo);
        Console.WriteLine("Factorial is: " + iRet);
    }
}
