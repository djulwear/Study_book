using System;
class MyClass
{
    public int alpha;
    public int bravo;
    public MyClass(int a)
    {
        Console.WriteLine("Construct with 1 argument");
        alpha = a;
        bravo = alpha;
        Console.WriteLine("Both fileds are equal  " + alpha);
    }
    public MyClass(int a,int b): this(a)
    {
        Console.WriteLine("Construct with 2 arguments");
        bravo = b;
        Console.WriteLine("Fields " + alpha + " & " + bravo);
    }
    public MyClass() : this(400, 500)
    {
        Console.WriteLine("Construct with out arguments");
        Console.WriteLine("Meaning " + alpha + " & " + bravo);
    }
}
class ConstrAndThisDemo
{
    static void Main()
    {
        MyClass A = new MyClass(100);
        Console.WriteLine();
        MyClass B = new MyClass(200, 300);
        Console.WriteLine();
        MyClass C = new MyClass();
    }
}