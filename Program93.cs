using System;

class Program93
{
    static int OddEvenDif(int []Arr, int iLength)
    {
        int i = 0;
        int EvenCount = 0;
        int OddCount = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] % 2 == 0)
            {
                EvenCount++;
            }
            else
            {
                OddCount++;
            }
        }
        return EvenCount - OddCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("How many nuumber you want to add in aray : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");

        int i = 0;

        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        int iRet = OddEvenDif(P, iSize);
        Console.WriteLine(iRet);
    }
}