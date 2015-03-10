using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        while (true)
        {
            int num = Int32.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            int numRight = num >> p;
            int bit = numRight & 1;
            Console.WriteLine(bit);
        }
    }
}
