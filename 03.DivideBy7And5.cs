using System;

class DivideBy7And5
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        bool chk = false;
        if (num % 5 == 0 && num % 7==0)
        {
            chk = true;
        }
        Console.WriteLine(chk);
    }
}
