using System;

class Program72
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        for(i = 0; i <= iRows-1; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                Console.Write((i + j)+"\t");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] Argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;

        Console.WriteLine("Enter the number of rows : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of column : ");
        iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);
    }
}