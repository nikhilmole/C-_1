using System;

class Program67
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;

        int iCnt = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                iCnt = iCnt+1;
                Console.Write(iCnt+"\t");
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] Argv)
    {

        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1, iNo2);

    }
}