using System;

class Program70
{
    static void Pattern(int iRows, int iCols)
    {
        int i = 0;
        int j = 0;
        char ch1 = '\0';
        char ch2 = '\0';

        for(i = 1, ch1 = 'a'; i <= iRows; i++,ch1++)
        {
            for(j = 1, ch2 = 'a'; j <= iRows; j++,ch2++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(j+"\t");
                }
                else
                {
                    Console.Write(ch2+"\t");
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

        Pattern(iNo1, iNo2);    
    }
}