using System;

class CurrencyConverter
{
    public int iValue;

    public CurrencyConverter(int iNum)
    {
        iValue = iNum;
    }

    public int DollarIntoINR()
    {
        int Rs = 70;
        int Ans = Rs * iValue;
        return Ans;
    }
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the number of dollars: ");
        int iNo = int.Parse(Console.ReadLine());

        CurrencyConverter cobj = new CurrencyConverter(iNo);

        int iRet = cobj.DollarIntoINR();
        Console.WriteLine("Equivalent in Indian Rupees: {0}", iRet);
    }
}
