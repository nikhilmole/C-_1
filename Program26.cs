using System;
class Program26
{
    void Display(int iNum)
    {
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        switch(iNum)
        {
            case 0:
                Console.WriteLine("Zero");
                break;

            case 1:
                Console.WriteLine("One");
                break;

            case 2:
                Console.WriteLine("Two");
                break;

            case 3:
                Console.WriteLine("Three");
                break;

            case 4:
                Console.WriteLine("Four");
                break;

            case 5:
                Console.WriteLine("Five");
                break;

            case 6:
                Console.WriteLine("Six");
                break;

            case 7:
                Console.WriteLine("Seven");
                break;

            case 8:
                Console.WriteLine("Eight");
                break;

            case 9:
                Console.WriteLine("Nine");
                break;
            
            default:
            Console.WriteLine("Invalid option");
            break;
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Program26 pobj = new Program26 ();
        pobj.Display(iNo);
    }
}