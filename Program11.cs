using System;

class Program11
{   
    void CheckGreaterOrLess(int iNum)
    {
        if(iNum < 10)
        {
            Console.WriteLine("Hello");
        }
        else
        {
            Console.WriteLine("Demo");
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program11 pobj = new Program11();

        pobj.CheckGreaterOrLess(iNo);
    }
}