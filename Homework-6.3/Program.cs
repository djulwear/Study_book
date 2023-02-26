using System;
using static System.Net.Mime.MediaTypeNames;
/*
Напишите программу с классом, у которого есть два целочисленных поля. В классе должны
быть описаны конструкторы, позволяющие создавать объекты без передачи аргументов,
с передачей одного аргумента  и с передачей двух аргументов.
 */

class Myclass
{
    public string FirstName;
    public string SecondName;

    public Myclass()
    {
        FirstName = "No Name";
        SecondName = "No Familia";
    }
    public Myclass(string k)
    {
        FirstName = k;
        SecondName = "No Second name";
    }

    public Myclass(string k, string l)
    {
        FirstName = k;
        SecondName = l;
    }

    //Для проверки! Метод шоу

    public void show()
    {
        Console.WriteLine("Player name: {0} \'{1}\'",FirstName , SecondName);
    }
}

class Demo
{
    static void Main()
    {
        Myclass A = new Myclass();
        Myclass B = new Myclass("Alex");
        Myclass C = new Myclass("Sam", "Duck");
        A.show();
        B.show();
        C.show();
    }
}