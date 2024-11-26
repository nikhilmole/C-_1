using System;

class Program20
{   
    void Pattern(int iNum)
    {
        int i = 0;

        for(i = 1; i <= iNum; i++)
        {
            Console.Write("$  *  ");
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program20 pobj = new Program20();
        pobj.Pattern(iNo);
    }
}