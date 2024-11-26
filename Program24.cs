using System;

class Program24
{
    void Multiple(int iNum)
    {
        int i = 0;

        for(i = 1; i <= 5; i++)
        {
            Console.WriteLine(iNum * i);
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program24 pobj = new Program24();

        pobj.Multiple(iNo);
    }
}