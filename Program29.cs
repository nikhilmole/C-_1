using System;

class Program29
{
    static void Pattern(int iNum)
    {
        int i = 0;

        for(i = 1; i <= iNum; i++)
        {
            Console.Write("*  ");
        }
        for(i = 1; i <= iNum; i++)
        {
            Console.Write("#  ");
        }
    }
    static void Main(string[] Argv)
    {
        int iNo = 0;

        Console.WriteLine("Enter the number : ");
        iNo = int.Parse(Console.ReadLine());

        Pattern(iNo);
    }
}