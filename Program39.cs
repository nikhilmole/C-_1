using System;

class Program39
{
    static void Display(int iNum1, int iNum2)
    {
        int i = 0;

        for(i = iNum1; i <= iNum2; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the first number : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Display(iNo1, iNo2);

    }
}