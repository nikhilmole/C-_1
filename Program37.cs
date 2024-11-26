using System;

class Program37
{
    static double SquareMeter(float fValue)
    {
        double Ans = 0.0f;

        Ans = 0.0929 * fValue;

        return Ans;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter Area in SqFit");
        float iNo = int.Parse(Console.ReadLine());

        double dRet = SquareMeter(iNo);
        Console.WriteLine(dRet);
    }
}