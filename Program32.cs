using System;

class Factorial
{
    public int iValue;

    public Factorial(int iNum)
    {
        iValue = iNum;
    }

    public int OddFacto()
    {
        int i = 0;
        int iFacto = 1;

        if(iValue < 0)
        {
            iValue= -iValue;
        }

        for(i = 1; i <= iValue; i++)
        {
            if(i % 2 != 0)
            {
                iFacto = iFacto * i;
            }
        }
        return iFacto;
    }
}

class Program32
{
    static void Main(String[] Argv)
    {
        int iNo = 0;

        Console.WriteLine("Enter the number : ");
        iNo = int.Parse(Console.ReadLine());

        Factorial fobj = new Factorial(iNo);

        int iRet = fobj.OddFacto();

        Console.WriteLine(iRet);
    }
}