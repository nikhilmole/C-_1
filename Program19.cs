using System;

class NonFacto
{
    public int iNum;

    public NonFacto(int iValue)
    {
        iNum = iValue;
    }
    public int NonFactoSum()
    {
        int i = 0;
        int iSum = 0;

        for( i = 1; i <= iNum; i++)
        {
            if(iNum % i != 0)
            {
                iSum = iSum + i;
            }
        }
        return iSum;
    }
}
class Program19
{
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        NonFacto fobj = new NonFacto(iNo);

        int iRet = fobj.NonFactoSum();
        Console.WriteLine("The summation of Non factorial is : "+iRet);
    }
}