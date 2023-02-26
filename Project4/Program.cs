using System;
class MyMath
    //Статические члены класса
{
    public const double Pi = 3.141592;
    private static int N = 100;
    public static double exp(double x)
    {
        double s = 0, q = 1;
        for(int k = 0; k <= N; k++)
        {
            s += q;
            q *= x / (k + 1);
        }
        return s;
    }
    public static double sin(double x)
    {
        double s = 0, q = x;
        for(int k = 0; k <= N; k++)
        {
            s += q;
            q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
        }
        return s;
    }
}
class StaticDemo
{
    static void Main()
    {
        double z = 1;
        Console.WriteLine("exp({0})={1}", z, MyMath.exp(z));
        Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));
        z = MyMath.Pi / 4;
        Console.WriteLine("sin({0})={1}", z, MyMath.sin(z));
        Console.WriteLine("контрольное значение: {0}", Math.Sin(z));
    }
}