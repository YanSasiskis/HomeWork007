using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle();
        Console.WriteLine("Please enter A side of triangle");
        triangle.TriangleA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter B side of triangle");
        triangle.TriangleB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter C side of triangle");
        triangle.TriangleC = Convert.ToDouble(Console.ReadLine());
        triangle.PrintInformationAboutTruangle();
    }
}
class Triangle
{
    private double _triangleA;
    private double _triangleB;
    private double _triangleC;
    private double _square;
    private double _semiperimeterOfATriangle;
    private double _perimeterOfATriangle;
    
    public double TriangleA
    {
        set
        {
            _triangleA = value;
        }
        get
        {
            return _triangleA;
        }
    }
    public double TriangleB
    {
        set
        {
            _triangleB = value;
        }
        get
        {
            return _triangleB;
        }
    }
    public double TriangleC
    {
        set
        {
            _triangleC = value;
        }
        get
        {
            return _triangleC;
        }
    }
    public double Square
    {
        set
        {
            _square = value;
        }
        get
        {
            return _square;
        }
    }
    public double SemiperimeterOfATriangle
    {
        set
        {
            _semiperimeterOfATriangle = value;
        }
        get
        {
            return _semiperimeterOfATriangle;
        }
    }
    public double PerimaterOfATriangle
    {
        set
        {
            _perimeterOfATriangle = value;
        }
        get
        {
            return _perimeterOfATriangle;
        }
    }

    private double CalculationOfTheSquareOfATruangle()
    {
        _semiperimeterOfATriangle = (_triangleA + _triangleB + _triangleC) / 2;
        _square = Math.Sqrt(_semiperimeterOfATriangle * (_semiperimeterOfATriangle - _triangleA) * (_semiperimeterOfATriangle - _triangleB) * (_semiperimeterOfATriangle - _triangleC));
        return _square;
    }
    public double CalculationOfThePerimeterOfATruangle()
    {
        _perimeterOfATriangle = (_triangleA + _triangleB + _triangleC);
        return _perimeterOfATriangle;
    }
    public void PrintInformationAboutTruangle()
    {
        CalculationOfThePerimeterOfATruangle();
        CalculationOfTheSquareOfATruangle();
        Console.WriteLine("Square of a truangle = {0}, Perimeter of a truangle = {1}", _square,_perimeterOfATriangle);
    }
}

/*
    Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три
    закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в 
    теле класса создайте 3 метода: 1-й для расчета площади треугольника, формула для расчета 𝑆 =
    √𝑝 ∗ (𝑝 − 𝑎) ∗ (𝑝 − 𝑏) ∗ (𝑝 − 𝑐), где 𝑝 - полупериметр треугольника 𝑝 = (𝑎 + 𝑏 + 𝑐)/2, a, b, c –
    длины сторон треугольника.

    2-й для расчета периметра треугольника, формула для расчета 𝑝 =
    (𝑎 + 𝑏 + 𝑐)/2 и 
    
    3-й для вывода информации о площади и периметре треугольника. Создайте 
    конструктор, который в качестве аргументов приминимает стороны треугольника и 
    инициализирует поля класса. В методе Main() создайте экземпляр класса «Треугольник», задайте 
    произвольное значение сторон треугольника и выведите на экран значение периметра и 
    площади треугольника
*/