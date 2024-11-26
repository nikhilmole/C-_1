using System;

class Program23
{
    void OddNumber(int iNum)
    {
        int i = 0;

        for(i = 1; i <= iNum; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Main(string [] Argv)
    {
        int iNo = 0;

        Console.WriteLine("Enter the number : ");
        iNo = int.Parse(Console.ReadLine());

        Program23 pobj = new Program23();

        pobj.OddNumber(iNo);

    }
}