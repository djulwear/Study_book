using System;
using System.Linq;
/* напишите программу со статическим методом, аргументом которому передаётся целочисленный массив,
* а результатом возвращается среднее значение для элементов массива
(сумма значений элементов, делится на количество элементов в массиве). */

class MyClass
{
    int class_field;

    public MyClass(int[] ints)
    {
        int k = ints.Length;
        class_field = GetArray(ints);
    }

    static int GetArray(int[]ints)
    {
        int middle = (int)Convert.ToInt64(ints.Average());
        Console.WriteLine("Middle is: " + middle);
        return middle;
    }

    public void Show()
    {
        Console.WriteLine("This class middle is: " + class_field);
    }
}
class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass(new int[] { 1, 2 });
        A.Show();
        MyClass B = new MyClass(new int[] { 1, 2,5,6,7,8,9,0,10});
        B.Show();
        A.Show();
    }
}