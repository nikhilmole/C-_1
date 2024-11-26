using System;

class Program38
{
    static void Display(int iNum1, int iNum2)
    {
        int i = 0;

        for(i = iNum1; i <= iNum2; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter First number : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        int iNo2 = int.Parse(Console.ReadLine());
        Display(iNo1,iNo2);

    }
}