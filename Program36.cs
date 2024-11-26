using System;

class Program36
{
    static float FhToCs(float Temp)
    {
        float Celcius = 0.0f;

        Celcius = (Temp - 32) * (5.0f/9.0f);

        return Celcius;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        float fNo = float.Parse(Console.ReadLine());

        float fRet = FhToCs(fNo);

        Console.WriteLine(fRet);
    }
}
