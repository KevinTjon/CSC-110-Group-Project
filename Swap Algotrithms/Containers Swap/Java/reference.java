// A Java program to demonstrate that we can swap two
// objects be swapping members.

class number
{
    int num;
    number(int num) 
    { 
        this.num = num; 
        
    }
}

public class reference
{
    public static void swap(number a, number b)
    {
        int temp = a.num;
        a.num = b.num;
        b.num = temp;
    }

    public static void main(String[] args)
    {
    number a = new number(1);
    number b = new number(2);
    swap(a, b);
    System.out.println("a = " + a.num);
    System.out.println("b = " + b.num);
    }
}
