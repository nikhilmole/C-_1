using System;


class Program10
{
    void Display(int iNo)
    {
        int i = 0;

        for(i = 1; i <= iNo; i++)
        {
            Console.Write("*  ");
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program10 pobj = new Program10();

        pobj.Display(iNo);

    }
}