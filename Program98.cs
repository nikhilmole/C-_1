using System;

class Program98
{
    static int FirstOcc(int []Arr, int iLength, int iNum)
    {
        int i = 0;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] == iNum)
            {
                return i + 1;
            }
        }
        return -1;
    }
    static void Main(string[] Argv)
    {
        int i = 0;

        Console.WriteLine("How many numbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Which number you want sear index : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = FirstOcc(P, iSize, iNo);

        if(iRet == -1)
        {
            Console.WriteLine("There is no number");
        }
        else
        {
            Console.WriteLine("The number First occuurance is : "+iRet);
        }
    }
}