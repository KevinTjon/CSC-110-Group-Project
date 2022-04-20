using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    
        int x = 1;
        int y = 2;
        
        x = x ^ y;
        y = y ^ x;
        x = x ^ y;

    
        Console.WriteLine("x=" + " " + x);
        Console.WriteLine("y=" + " " + y);
    }
}
