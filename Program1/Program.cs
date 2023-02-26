using System;
class MyClass
{
    private int number;
    private char symbol;
    public void show()
    {
        Console.WriteLine("поля объекта: " + number + " & " + symbol);
    }
    public void set (int n,char s)
    {
        number = n;
        symbol = s;
    }
    public void set(int n)
    {
        number = n;
        symbol = 'B';
    }
    public void set()
    {
        set(100, 'A');
    }
}
class MetodDemo
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.set();
        obj.show();
        obj.set(200);
        obj.show();
        obj.set(300, 'C');
        obj.show();
        Console.ReadLine();
    }
}