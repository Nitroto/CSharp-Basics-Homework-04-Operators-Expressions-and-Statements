using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        bool chk = false;

        if ((num / 100) % 10 == 7)
        {
            chk = true;
        }
        Console.WriteLine(chk);
    }
}
