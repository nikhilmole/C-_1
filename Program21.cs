using System;

class Program21
{
    void Pattern(int iNm)
    {
        int i = 0;

        for(i = 1; i <= iNm; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNO = int.Parse(Console.ReadLine());

        Program21 pobj = new Program21();

        pobj.Pattern(iNO);
    }
}