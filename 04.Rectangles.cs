using System;

class Rectangles
{
    static void Main()
    {
        double width = Double.Parse(Console.ReadLine());
        double height = Double.Parse(Console.ReadLine());
        double p = 2*width+2*height;
        double s = width * height;
        Console.WriteLine("Perimeter is: {0}", p);
        Console.WriteLine("Area is: {0}", s);

    }
}
