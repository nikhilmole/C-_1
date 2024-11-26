using System;

class Display
{
    public int iRows;
    public int iCols;

        public Display(int iRo, int iCo)
        {
            iRows = iRo;
            iCols = iCo;
        }

        public void Pattern()
        {
            int i = 0;
            int j = 0;

            for(i = iRows; i > 0; i--)
            {
                for(j = iCols; j > 0; j--)
                {
                    Console.Write(i+"  ");
                }
                Console.WriteLine();
            }
            
        }
}
class Program66
{
    public static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number of rows : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of cols : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Display dobj = new Display(iNo1, iNo2);

        dobj.Pattern();
    }
}