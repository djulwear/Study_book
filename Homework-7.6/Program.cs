/* напишите программу со статическим методом, аргументом которому передается текст, а результатом возвращается
 * символьный массив, состоящий из букв (без учета пробелов и знаков припинания), из которых состоит текст.
 * Если буква несколько раз встречается в тексте, в массиве она представлена одним элементом.
 * Буквы в массиве-результате должны быть отсортированы в алфавитном порядке. 
 */

using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;


class MyClass
{
    public static char[] SymbArrReturn(string input)
    {
        input = Regex.Replace(input, "[- .?!)|/(,:;'_[0-9\\]]", "");
        input=input.ToLower();
        input = String.Concat(input.OrderBy(ch => ch));

        char[] charArr = input.ToCharArray();

        char[] newArr = removeDuplicates(charArr);
        static T[] removeDuplicates<T>(T[] charArray)
        {
            HashSet<T> set = new HashSet<T>(charArray);
            T[] result = new T[set.Count];
            set.CopyTo(result);
            return result;
        }

        return newArr;
    }
    public MyClass(string input)
    {
        char[]charArr = SymbArrReturn(input);
        Show();


        void Show()
        {
            Console.Write("Result:");
            foreach (char i in charArr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}

class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass("Baca! de; f/|g G4g");
    }

}