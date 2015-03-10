using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        bool chk = false;
        if (num % 2 == 1)
        {
            chk = true;
        }
        Console.WriteLine(chk);
    }
}
