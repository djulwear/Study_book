using System;
using System.Text;

/*
 Напишите программу с классом, в котором есть закрытое символьное поле и три открытых метода:
1.Один из методов позволяет присвоить значение полю.
2.Еще один метод при вызове возвращает результатом код символа.
3.Третий метод позволяет вывести в консольное окно символ (значение поля) и его код.
 */


class MyClass
{
    private char MySymbol = 'A';

    public void set()
    {
        Console.Write("Enter new MySymbol:");
        char? s = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(" ");
        MySymbol = (char)s;
    }
    public void show()
    {
        Console.WriteLine("My symbol: '" + MySymbol +"' & Symbol code: "+ ((int)MySymbol));
    }
}

class MainClass
{

    static void Main()
    {
        MyClass Demo1 = new MyClass();
        Demo1.show();
        Demo1.set();
        Demo1.show();
        Demo1.set();
        Demo1.show();
        Demo1.set();
        Demo1.show();

        Console.ReadLine();
    }
}