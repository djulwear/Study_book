using System;
using System.Runtime.InteropServices;
using System.Text;
/* Напишите программу, в которой есть статический метод. Аргументом методу передаётся текстовое значение.
 * Результатом метод возвращает текст, в котором, по сравнению с текстом аргументом,
 * между символами вставлены пробелы. */

class MyClass
{
    public string clsFeild;
    public string clsFeildGPT;

    public static string SpaceChars (string k)
    {
        char[] charArr = k.ToCharArray();
        char[] copyArr = charArr;
        int plus = charArr.Length;
        Array.Resize(ref charArr, charArr.Length + plus);
        Array.Clear(charArr);
        int j = 0;
        char symb = '_';
        for (int i =0 ;i<plus;i++)
        {
            charArr[j] = copyArr[i];
            j++;
            charArr[j] = symb;
            j++;
        }
        string newk = new string(charArr);

        return newk;
    }


    public static string SpaceCharsGPT(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
        {
            sb.Append(c);
            sb.Append('_');
        }
        return sb.ToString();
    }

    public void Show()
    {
        Console.WriteLine("Our string (made by me ) is: "+clsFeild);
        Console.WriteLine("Our string (made by GPT) is: " + clsFeild);
    }

    public MyClass(string input)
    {
        clsFeild = SpaceChars(input);
        clsFeildGPT = SpaceCharsGPT(input);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass("Hello!");
        A.Show();
        MyClass B = new MyClass("Hello my friend, how are you?");
        B.Show();
        A.Show();
    }
}