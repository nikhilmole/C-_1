using System;

class Program53
{
    static void Pattern(int iNum)
    {
        int i = 0;
        char ch = '\0';

        for(i = 1, ch = 'A'; i <= iNum; i++, ch++)
        {
            Console.WriteLine(ch);
        }
    }
    
    static void Main(string[] args)
    {
        int iNo = 0;

        Console.WriteLine("Enter number: ");
        iNo = int.Parse(Console.ReadLine());

        Pattern(iNo);
    }
}
