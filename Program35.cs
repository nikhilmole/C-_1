using System;

class Program35
{
    static int KMTometer(int Meter, int Kilometer)
    {
        int Ans = 0;

        Ans = Meter * Kilometer;

        return Ans;
    }
    static void Main(String[] argv)
    {
        int iRet = 0;
        int pica = 1000;
        int iNo = 0;

        Console.WriteLine("Enter Kilometer : ");
        iNo = int.Parse(Console.ReadLine());

        iRet = KMTometer(pica, iNo);
        Console.WriteLine(iRet);
    }
}