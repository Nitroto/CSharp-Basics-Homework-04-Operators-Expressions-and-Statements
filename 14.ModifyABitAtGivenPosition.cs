using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        while(true)
        {
            int num = Int32.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            int mask, result;
            if (v == 1)
            {
                mask = 1 << p;
                result = num | mask;
            }
            else
            {
                mask = ~(1 << p);
                result = num & mask;
            }
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
        }
    }
}
