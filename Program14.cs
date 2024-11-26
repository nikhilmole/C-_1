using System;

class Program14
{
    void Display(int iNum)
    {
        int i = 0;

        for (i = 1; i <= (
            iNum*2); i++)
        {
            if((i % 2) == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNO1 = int.Parse(Console.ReadLine());

        Program14 pobj = new Program14();

        pobj.Display(iNO1);
    }
}