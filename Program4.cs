using System;

class Addition
{
    public int inum1;
    public int inum2;

    public Addition(int A, int B)
    {
        this.inum1 = A;
        this.inum2 = B;
    }

    public int Add()
    {
        int Ans = 0;
        Ans = this.inum1 + this.inum2;
        return Ans;
    }
}
class Program4
{
    static void Main(string[] Argv)
    {
        int iNo1 = 0;
        int iNo2 = 0;
        int iRet = 0;
        Console.WriteLine("Enter First number : ");
        iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second number : ");
        iNo2 = int.Parse(Console.ReadLine());

        Addition aobj = new Addition(iNo1, iNo2);
        iRet = aobj.Add();
        Console.WriteLine("Addition is : "+iRet);
    }
}