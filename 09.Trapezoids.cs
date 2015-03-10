using System;

class Trapezoids
{
    static void Main()
    {
        while (true)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double s = (((a + b) * h) / 2);
            Console.WriteLine(s);
        }
    }
}
