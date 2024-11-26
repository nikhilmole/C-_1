using System;

class Program54
{
    static void Pattern(int iNum)
    {
        int i = 0;

        for(i = iNum; i >= 0; i--)
        {
            Console.Write(i+"  #  ");
        }
    }
    static void Main(String[] Argv)
    {
        int iNo = 0;

        Console.WriteLine("Enter the number : ");
        iNo = int.Parse(Console.ReadLine());

        Pattern(iNo);
    }
}