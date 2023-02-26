using System;
class MyClass
{
    //Пример конструктора, название конструктора = название класса
    public int num;
    public char symb;
    public string txt;

    public void show()
    {
        Console.WriteLine("поля: {0}, \'{1}\'& \"{2}\"", num, symb, txt);
    }
    public MyClass()
    {
        num = 100;
        symb = 'A';
        txt = "red";
    }
    public MyClass(int n)
    {
        num = n;
        symb = 'B';
        txt = "yellow";
    }
    public MyClass(int n,char s)
    {
        num = n;
        symb = s;
        txt = "green";
    }
    public MyClass(int n, char s, string t)
    {
        num = n;
        symb = s;
        txt = t;
    }
    public MyClass(string t)
    {
        num = 0;
        symb = 'Z';
        txt = t;
    }
}
class ConstructorsDemo
{
    static void Main()
    {
        MyClass A = new MyClass();
        A.show();
        MyClass B = new MyClass(200);
        B.show();
        MyClass C = new MyClass(300,'C');
        C.show();
        MyClass D = new MyClass(400, 'D', "Blue");
        D.show();
        MyClass F = new MyClass('A');
        F.show();
        MyClass G = new MyClass("Gray");
        G.show();
        Console.ReadLine();
    }
}