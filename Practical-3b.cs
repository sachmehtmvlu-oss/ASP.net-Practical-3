using System;
delegate void Message();
class Demo
{
    public void Welcome()

    {
        Console.WriteLine("Welcome everyone");
    }
    public void Learn()
    {
        Console.WriteLine("We will learn C# Delegates");
    }
    public void thanku()
    {
        Console.WriteLine("Thank you everyone");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        Message msg;
        msg  = d.Welcome;
        msg += d.Learn;
        msg += d.thanku;
        msg();
        Console.WriteLine("Sachin Ramesh Mehta");
    }
}

