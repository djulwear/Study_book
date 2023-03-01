using System;
using System.Runtime.InteropServices;
/* Напишите программу, в которой есть статический метод. Аргументом методу передаётся текстовое значение.
 * Результатом метод возвращает текст, в котором, по сравнению с текстом аргументом,
 * между символами вставлены пробелы. */

class MyClass
{
    string k;

    public static string SpaceChars (string k)
    {
        char[] charArr = k.ToCharArray();
        char[] copyArr = charArr;
        Console.WriteLine(charArr.Length);
        Console.WriteLine(charArr);
        int p = 0;
        for (int l = 0; l < k.Length; l++,p++)
        {
        }

        Array.Resize(ref charArr, charArr.Length + p);
        Console.WriteLine(charArr.Length);
        Console.WriteLine(charArr);

        Array.Clear(charArr);
        Console.WriteLine(charArr.Length);
        Console.WriteLine(charArr);
        int j = 0;
        char symb = ' ';
        for (int l =0 ;l<p;l++)
        {
            charArr[j] = copyArr[l];
            j++;
            charArr[j] = symb;
            j++;
        }
        Console.WriteLine(charArr.Length);
        Console.WriteLine(charArr);
        string newk = new string(charArr);

        return newk;
    }

    public void Show()
    {
        Console.WriteLine("Our string is: "+k);
    }

    public MyClass(string k)
    {
        SpaceChars(k);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass("Hello!");
        A.Show();
        MyClass B = new MyClass("Goodbye");
        B.Show();
        A.Show();
    }
}