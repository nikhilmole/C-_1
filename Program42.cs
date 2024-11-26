using System;

class Program42
{
    static void RangeDisplayRev(int Start, int End)
    {
        int i = 0;
        if(Start > End)
        {
            Conosole.WriteLine("Invalid Option");
        }
        for(i = End; i >= Start; i--)
        {
            Console.WriteLine("{0}",i);
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter starting point");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter ending point");
        int iNo2 = int.Parse(Console.ReadLine());

        RangeDisplayRev(iNo1, iNo2);

    }
}