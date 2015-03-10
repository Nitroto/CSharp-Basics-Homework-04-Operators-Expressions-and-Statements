using System;

class ExtractBitNo3
{
    static void Main()
    {
        while(true)
        {
            int num = Int32.Parse(Console.ReadLine());
            int numRight = num >> 3;
            int bit = numRight & 1;
            Console.WriteLine(bit);
        }
    }
}
