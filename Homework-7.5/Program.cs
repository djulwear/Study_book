/* Напишите программу со статическим методом, определяющий позиции, на которых в тексте находится определённый символ.
 * Результатом метод возвращает целочисленный массив, значение элементов которого - это индексы позиций,
 * на которых символ (второй аргумент) находится в тексте (первый аргумент).
 * Если символ в тексте не встречается, то метод результатом возвращает массив из одного элемента, 
 * значение которого равно -1.
 */

using System;

class MyClass
{


    public static int [] PositionCheck(string txt, char chr)
    {
        int numberOfChr = 0;
        char[] charArr = txt.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (chr == charArr[i])
            {
                numberOfChr++;
            }

            if(numberOfChr ==0)
            {
                int[] Counters0 = { -1 };
                return Counters0;
            }
        }

        int[] Counters = new int[numberOfChr];
        int k = 0;
        for (int i = 0; i < charArr.Length; i++)
        {
            if(chr == charArr[i])
            {
                Counters[k] = i+1;
                k++;
            }
        }
        return Counters;
    }

    public MyClass(string inputS, char inputC)
    {
        Char myChar = inputC;
        int [] arrNum = PositionCheck(inputS,inputC);
        Show();


        void Show()
        {
            Console.Write("We have "+myChar+" in text on positions:");
            foreach (int i in arrNum)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
        }
    }
}

class MainClass
{
    static void Main()
    {
        MyClass A = new MyClass("This Text is Demo Text",'T');
        MyClass B = new MyClass("ooooOooOOOoo", 'o');
    }
}
