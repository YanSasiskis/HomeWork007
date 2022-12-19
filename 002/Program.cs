using System;
using System.Collections.Generic;
using System.Xml;

class Nikita13SM
{
    static void Main()
    {
       Cat cat = new Cat();
       cat.CreateInfo(name: "Markus", age: 1, coatColor: "Gray", eyeColor: "Brown");
       int amountMyaw = Convert.ToInt32(Console.ReadLine());
       cat.SayMyaw (ref amountMyaw);
       cat.PrintInfo();
    }
}
class Cat
{
    private string _name;
    private int _age;
    private string _coatColor;
    private string _eyeColor;

    public void CreateInfo(string name, int age, string coatColor, string eyeColor)
    {
        _name = name;
        _age = age;
        _coatColor = coatColor;
        _eyeColor = eyeColor;
    }
    public void SayMyaw(ref int amountMyaw)
    {
        for (int i = 0; i < amountMyaw; i++)  //Не совсем понял, нужно сделать два метода для вывода инфы про кота и кол-во мяу или что?
        {
            Console.WriteLine("Meaw");
        }    
    }
    public void PrintInfo()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_age);
        Console.WriteLine(_coatColor);
        Console.WriteLine(_eyeColor);
    }
}
/*
    Создайте программу в которой создайте класс «Котенок».
    В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого 
    поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод, который 
    будет выводить на консоль «Мяу», метод должен принимать один аргумент – количество «Мяу» 
    котенка, выводить «Мяу» соответствующее количество раз. В методе Main() создайте экземпляр
    класса «Котенок», присвойте всем полям значение через свойства доступа, а также вызовите 
    метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода передайте 3
*/