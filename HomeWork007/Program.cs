using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;

class Adress
{
    private string country;
    private string city;
    private string street;
    private string house;
    private string nummerOfHouse;
    private string index;
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Street
    {
        get { return street; }
        set { street = value; }
    }
    public string House
    {
        get { return house; }
        set { house = value; }
    }
    public string NummerOfHouse
    {
        get { return nummerOfHouse; }
        set { nummerOfHouse = value; }
    }
    public string Index
    {
        get { return index; }
        set { index = value; }
    }
    public Adress(string country, string city, string street, string house, string nummerOfHouse, string index)
    {
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.nummerOfHouse = nummerOfHouse;
        this.index = index;
    } 
    public void PrintInfo()
    {
        Console.WriteLine(country);
        Console.WriteLine(city);
        Console.WriteLine(street);
        Console.WriteLine(house);
        Console.WriteLine(nummerOfHouse);
        Console.WriteLine(index);
    }
}
class Program
{
    static void Main()
    {
        Adress adress = new Adress("Ukraine", "Kyiv", "VolodumiraZelenskogo", "B", "23", "4863EE");
        adress.PrintInfo();
    }    
}
/* 
   Создайте программу в которой создайте класс «Адрес». 
   В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
   Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо 
   создать метод для отображения информации про адрес. В методе Main() создайте экземпляр
   класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр
   класса вызовите метод, который выводит информацию про адрес.
*/