using System;

class Program6
{
    int Divide(int iValue1, int iValue2)
    {
        if (iValue2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        int Ans = iValue1 / iValue2;

        return Ans;
    }

    static void Main(string[] Argv)
    {
        {
            Console.WriteLine("Enter the 1st number: ");
            int iNo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            int iNo2 = int.Parse(Console.ReadLine());

            Program6 pobj = new Program6(); // Corrected the class name here

            int result = pobj.Divide(iNo1, iNo2);

            Console.WriteLine("The result of division is: " + result);
        }
        
    }
}
