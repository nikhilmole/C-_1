using System;

class Program87
{
    static int Diff(int []Arr, int iLength)
    {
        int i = 0;
        int OddSum = 0;
        int EvenSum = 0;
        int Ans = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] % 2 == 0)
            {
                EvenSum = EvenSum + Arr[i];
            }
            else
            {
                OddSum = OddSum + Arr[i];
            }
        }
        Ans = EvenSum - OddSum;

        return Ans;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] Arr = new int [iSize];

        Console.WriteLine("Enter the elements you want to add in array : ");
        for(int i = 0; i < iSize; i++)
        {
            Arr[i] = int.Parse(Console.ReadLine());
        }

        int iRet = Diff(Arr,iSize);
        Console.WriteLine(iRet);
    }
}