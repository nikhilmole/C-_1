using System;

class Program12
{
    void Display(int iSize, int iNum)
    {
        int i = 0;

        for(i = 1; i < iSize; i++)
        {
            Console.WriteLine(iNum);
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("How many time u want to print on screen : ");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number you want to pring on screen : ");
        int iNo2 = int.Parse(Console.ReadLine());

        Program12 pobj = new Program12();
        
        pobj.Display(iNo1,iNo2);

    }
}