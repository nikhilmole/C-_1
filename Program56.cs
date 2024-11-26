using System;

class Program55
{
    static void Pattern(int iNum)
    {
        int i = 0;

        for(i = 1; i <= iNum; i++)
        {
            Console.Write("*  "+i+"  #  ");
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Pattern(iNo);
    }
}