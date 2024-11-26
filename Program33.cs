using System;

class Program33
{
    static int DifOddEvenFacto(int iNum)
    {
        int i = 0;
        int iOddFacto = 1;
        int iEvenFacto = 1;

        if(iNum < 0)
        {
            iNum = -iNum;
        }

        
        for(i = 1; i <= iNum; i++)
        {
            if(i % 2 == 0)
            {
                iEvenFacto = iEvenFacto * i;
            }
            else
            {
                iOddFacto = iOddFacto * i;
            }
        }
        return iEvenFacto - iOddFacto;
    }
    static void Main(String[] Argv)
    {
        int iNo = 0;

        Console.WriteLine("Enter the number : ");
        iNo = int.Parse(Console.ReadLine());

        int iRet = DifOddEvenFacto(iNo);
        Console.WriteLine(iRet);
    }
}