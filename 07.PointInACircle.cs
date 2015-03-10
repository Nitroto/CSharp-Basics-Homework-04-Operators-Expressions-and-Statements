using System;

class PointInACircle
{
    static void Main()
    {
        while (true)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double r = 2;
            bool inCircle = false;
            if ((x *x + y *y) <= r*r)
            {
                inCircle = true;
            }
            Console.WriteLine(inCircle);
        }
    }
}
