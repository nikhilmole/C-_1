using System;

class Program25
{
    void Number(int iNum)
    {
        if(iNum < 50)
        {
            Console.WriteLine("Small");
        }
        else if((iNum > 50) && (iNum < 100))
        {
            Console.WriteLine("Medium");
        }
        else
        {
            Console.WriteLine("Large");
        }
    }

    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program25 pobj = new Program25();

        pobj.Number(iNo);

    }
}