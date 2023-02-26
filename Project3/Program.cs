using System;
class MyClass
{
    //деструктор пример, но не работвет в консоли удаление классов
    private string name;
    public MyClass(string txt)
    {
        name = txt;
        Console.WriteLine("создан объект \"{0}\"", name);
    }
    ~MyClass()
    {
        Console.WriteLine("Deleted object \"{0}\"", name);
    }
}
    class DestructorDemo
    {
        static void maker(string txt)
        {
            new MyClass(txt);
        }


        static void Main()
        {
            MyClass A = new MyClass("first");
            new MyClass("second");
            A = new MyClass("third");
            maker("fourth");
            A = new MyClass("fifth");
        }
    }
