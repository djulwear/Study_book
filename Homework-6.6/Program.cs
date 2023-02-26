using System;

/* Напишите программу с классом, в котором есть два закрытых целочисленных поля (назовем их max & min).
 * Значение поля max не может быть меньше чем значение поля min.
 * Значение полям присваиваются с помощью открытого метода. 
 * Метод может вызываться с одним или двумя целочисленными аргументами.
 * При вызове метода значение полям присваиваются так:
 * сравниваются текущие значения полей и значения аргумента или аргументов, передаваемых методу.
 * Самое большое из значений присваивается полю max, а самое маленькое из значений присваивается полю min.
 * Предусмотрите конструктор, который работает по тому же принципу, что и метод для присваивания значений полям.
 * В классе также должен быть метод, отображающий в консольном окне значения полей объекта.
 */

class Myclass
{
    private int max, min = default;

    public void GetNums(int k)
    {
        defaultCheck(ref max);
        defaultCheck(ref min);

        int[] nums = { max, min, (int)k};
        min = nums.Min();
        max = nums.Max();

        int defaultCheck(ref int dnum)
        {
            if (dnum == default)
            {
                List<int> numbers = new List<int> { k };
                double average = numbers.Average();
                dnum = (int)average;
            }
            return dnum;
        }
    }

    public void GetNums(int k, int l)
    {
        defaultCheck(ref max);
        defaultCheck(ref min);

        int[] nums = {max,min, (int)k,(int)l};
        min = nums.Min();
        max = nums.Max();

        int defaultCheck(ref int dnum)
        {
            if (dnum == default)
            {
                List<int> numbers = new List<int> { k, l };
                double average = numbers.Average();
                dnum = (int)average;
            }
            return dnum;
        }
    }
   
    public void show()
    {
        if(min == max)
        {
            Console.WriteLine("Min & max numbers are same: " + min);
        }
        else { 
        Console.WriteLine("Min Number is: " + min + " & Max number is: "+max);
             }
    }

    public Myclass(int k)
    {
        GetNums(k);
    }

    public Myclass (int k, int l)
    {
        GetNums(k,l);
        
    }
}

class MainClass
{
    static void Main()
    {
        Myclass A = new Myclass(3,5);
        A.show();
        A.GetNums(-4,7);
        A.show();
        Myclass B = new Myclass(4);
        B.show();
        B.GetNums(5);
        B.show();
        B.GetNums(3);
        B.show();
    }
}