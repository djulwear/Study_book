using System;

/* напишите программу с классом, у которого есть символьное и целочисленное поле.
 * В классе должны быть описаны версии конструктора с двумя аргументами (целое число и символ - определяют значение полей),
 * а также с одним аргументом типа double. 
 * В последнем случае действительная часть аргумента определяет код символа (значение символьного поля),
 * а дробная часть (с учетом десятых и сотых) определяет значение целочисленного поля.
 * Например, если аргументом передается число 65.1267, то значение символьного поля будет А с кодом 65, 
 * а целочисленное поле получит значение 12 (в дробной части учитываются только десятые и сотые).
 */

class Myclass
{
    public int num;
    public char symb;
    public double dnum;

    public Myclass(int k, char s)
    {
        num = k;
        symb = s;
    }
    public Myclass(double d):this(1,'B')
    {
        dnum = d;
        double p = Math.Truncate(dnum);
        symb = (char)p;
        double kl = (d - (double)p)*100;
        num = (int)kl;
    }
    public int Conv(double d)
    {
        int l = Convert.ToInt32(dnum);
        return l;
    }
    // проверка через метод show
    public void show()
    {
        Console.WriteLine("Number is " + num+ " and symbol is: " +symb+" ,also double: "+dnum);
    }


}

class Mainclass
{
    static void Main()
    {
        Console.WriteLine("63=? 64=@ 65=A 66=B 67=C 68=D 69=E");
        Myclass A = new Myclass(45,'F');
        Myclass B = new Myclass(63.216);
        Myclass C = new Myclass(67.9999999);
        A.show();
        B.show();
        C.show();
    }
}