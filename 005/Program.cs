using System;
using System.Collections.Generic;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        Point[] pointArray = new Point[4]
        {
            new Point(){X = 5,Y = 3, NameOfPoint = "A" },
            new Point(){X = 5,Y = 3, NameOfPoint = "B" },
            new Point(){X = 5,Y = 3, NameOfPoint = "C" },
            new Point(){X = 5,Y = 3, NameOfPoint = "D" }
        };
        Figure figure1 = new Figure(pointArray[0], pointArray[1], pointArray[2]);
        double sumTriangle = figure1.Perimeter();
        Console.WriteLine("Sum triangle = {0}", sumTriangle);

        Figure figure2 = new Figure(pointArray[0], pointArray[1], pointArray[2], pointArray[3]);
        double sumQuadrate = figure2.Perimeter();
        Console.WriteLine("Sum quadrate = {0}", sumQuadrate);
    }
}


class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public string NameOfPoint{ get; set; }
    // тут надо создать конструктор для иници... но я такой бля зачем если в мейне можно...
}
class Figure
{
    public Point[] arrayOfPoints { get; set; }
    private string nameOfFigure = string.Empty;

    public Figure(Point A, Point B, Point C)
    {
        arrayOfPoints = new Point[3];
        arrayOfPoints[0] = A;
        arrayOfPoints[1] = B;
        arrayOfPoints[2] = C;
    }
    public Figure(Point A, Point B, Point C,Point D)
    {
        arrayOfPoints = new Point[4];
        arrayOfPoints[0] = A;
        arrayOfPoints[1] = B;
        arrayOfPoints[2] = C;
        arrayOfPoints[3] = D;
    }
    public double CalculateSideOfFigure(Point sideA,Point sideB)
    {
        double sideLenght = Math.Sqrt(Math.Pow(sideB.X - sideA.X, 2) + Math.Pow(sideB.Y - sideA.Y, 2));
        return sideLenght;
    }
    public double Perimeter()
    {
        double sum = 0;
        for (int i = 0; i < arrayOfPoints.Length - 1; i++)
        {
            if (i == 0)
            {
                sum+= CalculateSideOfFigure(arrayOfPoints[arrayOfPoints.Length - 1],arrayOfPoints[0]);
            }
            sum += CalculateSideOfFigure(arrayOfPoints[i], arrayOfPoints[i + 1]);
        }
        return sum;
    }
}



/*
  Создайте программу, в которой создайте класс «Точка» – для описания координат точки на 
  координатной прямой рис №1. В теле класса создайте следующие закрытые поля: целочисленное 
  поле для описания координаты точки X и целочисленное поле для описания координаты точки 
  Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и 
  set, ????а также конструктор класса, который будет инициализировать данные поля значениями 
  аргументов. ???

  Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив 
  «Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3
  (треугольника) и 4 аргумента (четырехугольника). 
  В теле класса «Фигура» создайте два метода:

  1-й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и 
  возвращать длину стороны, формула для расчета 𝑑 = √(𝑥2 − 𝑥1)
  2 + (𝑦2 − 𝑦1 )
  2 и метод для 
  расчета периметра фигуры (подсказка – в методе циклом перебирать массив «Точек», пока в нем 
  будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать периметр 
  треугольника, квадрата, прямоугольника, точки выбрать произвольные
*/ 