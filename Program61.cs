using System;

class Program58
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                if(j % 2 == 0)
                {
                    Console.Write("# ");
                }
                else
                {
                    Console.Write(" * ");
                }
            }
            Console.WriteLine();
        }
    }
    public static void Main(String[] Argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;

        Console.WriteLine("enter the number of Rows : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the number of Cols : ");
        iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);

    }
}