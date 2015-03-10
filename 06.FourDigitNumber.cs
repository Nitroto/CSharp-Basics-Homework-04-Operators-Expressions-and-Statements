using System;
using System.Linq;

class FourDigitNumber
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        if (num / 1000 % 10 != 0)
        {
            int s = num.ToString().Sum(c => c - '0');
            Console.WriteLine(s);
            int reversed = num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
            Console.WriteLine(reversed);
            int dabc = (num % 10) * 1000 + (num / 10);
            Console.WriteLine(dabc);
            int acbd = (num / 1000) * 1000 + (num / 10 % 10) * 100 + (num / 100 % 10) * 10 + num % 10;
            Console.WriteLine(acbd);
        }
        else
        {
            Console.WriteLine("The number can not start with 0!!!");
        }
    }
}
