using System;

class Program34
{
    static float CircleArea(float PI, float Radius)
    {
        float Area = 0.0f;

        Area = PI * Radius * Radius;

        return Area;
    }
    static void Main(String[] Argv)
    {
        float PI = 3.14f;
        Console.WriteLine("Enter Radius : ");
        float fValue = float.Parse(Console.ReadLine());

        float fRet = CircleArea(PI,fValue);

        Console.WriteLine(fRet);
        
    }
}