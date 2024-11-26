using System;


class Program16
{
    void EvenNumber(int iNum)
    {
        int i = 0;

        for(i = 1; i <= iNum/2; i++)
        {
            if((i % 2 == 0) && (iNum % i == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program16 pobj = new Program16();

        pobj.EvenNumber(iNo);
    }
}