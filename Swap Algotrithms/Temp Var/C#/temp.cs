using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    
        int x = 1;
        int y = 2;
    
        int tempswap = x;
        x = y;
        y = tempswap;
    
        Console.WriteLine("x=" + " " + x);
        Console.WriteLine("y=" + " " + y);
    }
}
