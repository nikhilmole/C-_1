using System;

class Program74
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1;j <= iCols; j++)
            {
                if(j <= iCols - i + 1)
                {
                    Console.Write("*\t");
                }
                else
                {
                    Console.Write("#\t");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.W
        riteLine("Enter the number of column : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);
    }
}