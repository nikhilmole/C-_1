using System;

class Program31
{
    static int EvenFactorial(int iNum)
    {
        int i = 0;
        int iFacto = 1;
        if(iNum < 0)
        {
            iNum = -iNum;
        }
        for(i = 1; i <= iNum; i++)
        {
            if(i % 2 == 0)
            {
                iFacto = iFacto * i;
            }
        }
        return iFacto;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = EvenFactorial(iNo);

        Console.WriteLine("{0}",iRet);
    }
}