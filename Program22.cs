using System;


class Program22
{
    void Pattern(int iNum)
    {
        int i = 0;

        for(i = -iNum; i <= iNum; i++)
        {
            Console.Write(i+"  ");
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter thhe number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program22 pobj = new Program22();

        pobj.Pattern(iNo);
    }
}