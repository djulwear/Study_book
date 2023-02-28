using System;

/* Напишите программу с классом, в котором есть два поля: символьное и текстовое.
 * В классе должен быть перегруженный метод для присваивания значений полям.
 * Если метод вызывается с символьным аргументов, то соответствующее значение присваивается символьному полю.
 * Если метод вызывается с текстовым аргументом, то он определяет значение текстового поля.
 * Методу аргументом также может передаваться символьный массив.
 * Если массив состоит из одного элемента, то он определяет значение символьного поля.
 * В противном случае (если в массиве больше одного элемента) из символов массива формируется текстовая строка и 
 * присваивается значением текстовому полю.
 */

class MyClass
{
    char symb;
    string? text;
    public char GetInfo(char k)
    {
        this.symb = k;
        return symb;
    }
    public string GetInfo(string k)
    {
        this.text = k;
        return text;
    }

    public void GetInfo(char[] Array)
    {
        int lenght = Array.Length;
        if (lenght == 1)
        {
            symb = Array[0];
        }
        else
        {
            text = new string (Array);
        }
    }

    public void Show()
    {
        Console.WriteLine("Char: " + symb + " & string: " + text);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass();
        A.Show();
        A.GetInfo('F');
        A.Show();
        A.GetInfo("hhhh");
        A.Show();
        char[] example1 = { 'K' };
        A.GetInfo(example1);
        A.Show();
        char[] example2 = { 'L', 'O','X' };
        A.GetInfo('O');
        A.GetInfo(example2);
        A.Show();
        MyClass B = new MyClass();
        B.Show();
    }
}