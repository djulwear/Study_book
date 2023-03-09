/* напишите программу, в которой есть статический метод, 
 * возвращающий результатом текстовое значение и получающий аргументом текст.
 * Результат метода - это переданный аргументом текст, в котором слова следают в обратном порядке.
 * Словами считать блок текста, разделённые пробеломи.
 
   Операции со строками: https://metanit.com/sharp/tutorial/7.2.php
   Разделение строк с помощью string.split: https://learn.microsoft.com/ru-ru/dotnet/csharp/how-to/parse-strings-using-split
 */

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MyClass
{
    private string classField;

    static string SplitAndReverse(string text)
    {
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        text = string.Join(" ", words);
        return text;
    }

    public MyClass(string input)
    {
        classField = SplitAndReverse(input);
    }

    public void Show()
    {
        Console.WriteLine(classField);
    }
}

class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass("Hello my name is Json!");
        A.Show();
    }
}