using System;


class Program7
{
    void Display(int iValue)
    {
        int i = 0;

        for(i = 1; i < iValue; i++)
        {
            Console.WriteLine("Jai Ganesh...");
            
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program7 pobj = new Program7();

        pobj.Display(iNo);
    }
}