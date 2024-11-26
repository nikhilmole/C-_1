using System;

class Program28
{
    static void Table(int iNum)
    {
        int i = 0;

        for(i = 1; i <= 10; i++)
        {
            Console.WriteLine(iNum * i);
        }
    }
    static void Main(string[] Argv)
    {
        int iNo = 0;

        Console.WriteLine("Enter the number : ");
        iNo = int.Parse(Console.ReadLine());

        Table(iNo);
    }

}