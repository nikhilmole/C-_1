using System;

class Program73
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                if(i == j || i > j)
                {
                    Console.Write("*"+"\t");
                }
                else
                {
                    Console.Write("#"+"\t");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of column : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);
    }
}