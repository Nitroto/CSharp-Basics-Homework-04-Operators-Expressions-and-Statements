using System;

class BitsExchange
{
    static void Main()
    {
        while (true)
        {
            long n = Int64.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            long firstThreeBits = n << 21;
            long secondThreeBits = n >> 21;
            long firstMask = 7 << 24 & firstThreeBits;
            long secondMask = 7 << 3 & secondThreeBits;
            long thirdMask = ~((7 << 24) | (7 << 3)) & n;
            long result = firstMask | secondMask | thirdMask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine(result);
        }
    }
}
