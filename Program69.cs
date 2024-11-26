using System;

class Program69
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(j * 2+"\t");
                }
                else
                {
                    Console.Write((j - 1) * 2 + 1+"\t");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);

    }
}