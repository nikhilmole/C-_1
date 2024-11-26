using System;

class Program99
{
    static int LastOcc(int []Arr, int iLength, int iNum)
    {
        int i = 0;

        for(i = iLength-1; i > 0; i--)
        {
            if(Arr[i] == iNum)
            {
                return  i + 1;
            }
        }
        return -1;
    }
    static void Main(String[] Argv)
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

        Console.WriteLine("Enter number for search last Occurance : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = LastOcc(P, iSize, iNo);

        if(iRet == -1)
        {
            Console.WriteLine("The number is not present");
        }
        else
        {
            Console.WriteLine("Last Occurance is : "+iRet);
        }
    }
}