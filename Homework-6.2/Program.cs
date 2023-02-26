using System;
using System.Text;

/* 
Напишите программу с классом, у которого есть два символьных поля и метод.
Он не возвращает результат, и у него нет аргументов. При вызове метод выводит в
консольное окно все символы из кодовой таблицы, которые находятся между символами,
являющимися значениями полей объекта (из которого вызывается метод)
Например, если полям объекта присвоины значения А и D то при вызове метода в консольное
окно должны выводится все символы от А до D включительно.
*/

class Myclass
{
    private char Mychar1 = 'A', Mychar2 = 'D';

    public void show()
    {
        Console.Write("Chars: ");
        int k = ((int)Mychar1);
        for (; k < ((int)Mychar2); k++)
        {
            Console.Write(" "+((char)k));
        }
        Console.WriteLine(" " + Mychar2);
    }

    public void set1()
    {
        Console.Write("Enter new MySymbol:");
        char? s = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(" ");
        Mychar1 = (char)s;
    }
    public void set2()
    {
        Console.Write("Enter new MySymbol:");
        char? s = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(" ");
        Mychar2 = (char)s;
    }
}

class MainClass
{
    static void Main()
    {
        Myclass obj = new Myclass();
        obj.show();
        obj.set1();
        obj.set2();
        obj.show();
    }
}