using System;

class Program8
{
    void Display(int iValue)
    {
        int i = 0;

        for (i = 1; i <= iValue; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Main(string [] Argv)
    {
        Console.WriteLine("Enter the number :");
        int iNo = int.Parse(Console.ReadLine());

        Program8 pobj = new Program8();

        pobj.Display(iNo);
    }
}