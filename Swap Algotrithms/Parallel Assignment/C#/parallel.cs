using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    
        int x = 10;
        int y = 2;
        (x, y) = (y, x);
    
        Console.WriteLine("x=" + " " + x);
        Console.WriteLine("y=" + " " + y);
    }
}
