using System;

class PrimeNumberCheck
{
    static void Main()
    {
        sbyte n = sbyte.Parse(Console.ReadLine());
        bool prime = false;
        byte count = 0;
        if (n > 0 && n>1)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2 || n == 1)
            {
                prime = true;
            }
        }
        Console.WriteLine(prime);
    }
}
