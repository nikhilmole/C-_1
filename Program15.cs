using System;

class Program15
{
    void Factors(int iNum)
    {
        int i = 0;

        for(i = 1; i <= iNum/2;i++)
        {
            if((iNum % i) == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Wnter the number");
        int iNo = int.Parse(Console.ReadLine());

        Program15 pobj = new Program15();

        pobj.Factors(iNo);
    }
}