using System;

class Program71
{
    static void Pattern(int iRows, int iCols)
    {
        int i  = 0;
        int j = 0;

        for(i = 1; i <= iRows; i++)
        {
            for(j = 1; j <= iCols; j++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(-j+"\t");
                }
                else
                {
                    Console.Write(j+"\t");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(String[] Argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;

        Console.WriteLine("Enter the number of rows : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        iNo2 = int.Parse(Console.ReadLine());

        Pattern(iNo1,iNo2);
    }   
}