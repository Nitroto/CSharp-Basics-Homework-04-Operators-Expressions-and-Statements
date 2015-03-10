using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        while (true)
        {
            int num = Int32.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            int numRight = num >> p;
            int bit = numRight & 1;
            bool isOne = false;
            if (bit == 1)
            {
                isOne = true;
            }
            Console.WriteLine(isOne);
        }
    }
}
