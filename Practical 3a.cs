using System;

delegate void operation(int a, int b);
class Calculator
{
    public void add(int a, int b)
    {
        Console.WriteLine("Addition of number :" + (a + b));
    }
    public void sub(int a, int b)
    {
        Console.WriteLine("Subtraction of number :" + (a - b));
    }
    public void mul(int a, int b)
    {
        Console.WriteLine("Multiplication of number :" + (a * b));
    }
    public void div(int a, int b)
    {
        Console.WriteLine("Division of number :" + (a / b));
    }

}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        operation obj;

        obj = c.add;
        obj(14, 14);

        obj = c.sub;
        obj(14, 14);

        obj = c.mul;
        obj(14, 14);

        obj = c.div;
        obj(14, 14);

        Console.WriteLine("Sachin Ramesh Mehta");
    }
}

