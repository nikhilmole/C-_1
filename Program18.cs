using System;

class Program18
{
    void NonFacto(int iNum)
    {
        int i = 0;
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        for(i = 1; i < iNum; i++)
        {
            if(iNum % i != 0)
            {
                Console.WriteLine("The non Factorial number is : "+i);
            }
        }
    }
    static void Main(String[] Srgv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program18 pobj  = new Program18();

        pobj.NonFacto(iNo);
    }
}