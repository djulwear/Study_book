using System;
/* Напишите программу с классом, в котором есть статические методы, 
 * которым можно передавать произвольное количество целочисленных аргументов (или целочисленный массив).
 * Методы, на основании переданных аргументов или массива, позволяют вычислить - наибольшее значение,
 * а так же среднее значение из набора чисел. */

class MyClass
{
    public static int max = default;
    public static int middle = default;

    public static void GetNumber(params int[] num)
    {
        max = num.Max();
        middle = (int)num.Average();
        Console.WriteLine("GetNumber: Max number is: " + max + " and middle number is: " + middle);
    }
    public void Show()
    {
        Console.WriteLine("Show: Max number is: " + max + " and middle number is: " + middle);
    }

    class MainClass
    {
        static void Main()
        {
            int[] example1 = { 1, 4, 6, 8, 9, 0, 6 };
            MyClass Demo1 = new MyClass();
            MyClass Demo2 = new MyClass();
            GetNumber(1,10);
            Demo1.Show();
            GetNumber(example1);
            Demo1.Show();
            Demo2.Show();
        }
    }
}