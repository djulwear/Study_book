using System;
/* Напишите программу с классом, в котором есть статические методы, 
 * которым можно передавать произвольное количество целочисленных аргументов (или целочисленный массив).
 * Методы, на основании переданных аргументов или массива, позволяют вычислить - наибольшее значение,
 * а так же среднее значение из набора чисел. */

class MyClass
{
    static int max;
    static int middle;

    public static void GetNumber(params int[] num)
    {
        int max = num.Max();
        int middle = (int)num.Average();
        
    }
    public void Show()
    {
        Console.WriteLine("Max number is: " + max + " and middle number is: " + middle);
    }

    class MainClass
    {
        static void Main()
        {
            int[] example1 = { 1, 4, 6, 8, 9, 0, 6 };
            MyClass Demo1 = new MyClass();
            GetNumber(5,6);
            Demo1.Show();
            GetNumber(example1);
            Demo1.Show();
        }
    }
}