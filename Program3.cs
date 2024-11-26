using System;

class Program3
{
    int Addition(int inum1, int inum2)
    {
        int Ans = 0;
        Ans = inum1 + inum2;
        return Ans;
    }
    static void Main(String[] argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;
        int iRet = 0;

        Program3 pobj = new Program3();

        Console.WriteLine("Enter First number : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number : ");
        iNo2 = int.Parse(Console.ReadLine());

        iRet = pobj.Addition(iNo1,iNo2);
        Console.WriteLine("Addition is : "+iRet);
    }
}