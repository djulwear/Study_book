using System;

/* Напишите программу с классом, в котором есть закрытое статическое целочисленное поле с начальным нулевым значением.
 * В классе должен быть описан статический метод, при вызове которого отображается текущее значение статического поля,
 * после чего значения поля увеличивается на еденицу
 */

class MyClass
{
    private static int numCounter = 0;

    public static void CounterPlus()
    {
        Console.WriteLine("Number of counters is: " + numCounter + " ,but now added one plus.");
        numCounter++;
    }

    public void show()
    {
        Console.WriteLine("Number of counters is: "+numCounter);
    }

}
class MainClass
{
    static void Main()
    {
        MyClass Demo = new MyClass();
        MyClass.CounterPlus();
        MyClass.CounterPlus();
        MyClass.CounterPlus();
        Demo.show();
        MyClass.CounterPlus();
        MyClass.CounterPlus();
        MyClass Demo2 = new MyClass();
        Demo2.show();
    }
}
