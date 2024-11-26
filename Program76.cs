using System;

class Program76
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                if((i == 1) || (j == 1)||(i == iRows)||(j == iCols))
                {
                    Console.Write("*\t");
                }
                else
                {
                    Console.Write("@\t");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of column : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);
    }
}