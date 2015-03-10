using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        while (true)
        {
            long n = Int64.Parse(Console.ReadLine());
            sbyte p = sbyte.Parse(Console.ReadLine());
            sbyte q = sbyte.Parse(Console.ReadLine());
            byte k = byte.Parse(Console.ReadLine());
            int i = 0;
            long firstKBits;
            long secondKBits;
            long firstMask;
            long secondMask;
            long generatedMask=0;
            if (((p + k) <= 32) & ((q+k)<=32) && (Math.Abs(p - q) > k)&& p>=0 && q>=0)
            {
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                do
                {
                    generatedMask = (generatedMask << 1) | 1;
                    i++;
                } while (i < k);
                if (p < q)
                {
                    firstKBits = n << Math.Abs(p - q);
                    secondKBits = n >> Math.Abs(p - q);
                    firstMask = generatedMask << q & firstKBits;
                    secondMask = generatedMask << p & secondKBits;
                }
                else
                {
                    firstKBits = n >> Math.Abs(p - q);
                    secondKBits = n << Math.Abs(p - q);
                    firstMask = generatedMask << q & firstKBits;
                    secondMask = generatedMask << p & secondKBits;
                }
                long thirdMask = ~((generatedMask << p) | (generatedMask << q)) & n;
                long result = firstMask | secondMask | thirdMask;
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine(result);
            }
            else
            {
                if (((p + k) > 31)||((q+k)>31))
                {
                    Console.WriteLine("out of range");
                }
                else
                {
                    Console.WriteLine("overlapping");
                }
            }
        }
    }
}
