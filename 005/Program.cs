using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Point[] ArrayOfPoint = new Point[4];
        {
            new Point()
            {
                X = 5,
                Y = 6,
                NameOfPoint = "Nikita"
            };
            new Point()
            {
                X = 2,
                Y = 8,
                NameOfPoint = "Spasibo"
            };
            new Point()
            {
                X = 1,
                Y = 5,
                NameOfPoint = "ZA"
            };
            new Point()
            {
                X = 8,
                Y = 6,
                NameOfPoint = "KOD"
            };

            Figure Figura = new Figure(ArrayOfPoint[0], ArrayOfPoint[1], ArrayOfPoint[2]);
            double resultFigura = Figura.CalculatePerimetrOfFigure();
            Console.WriteLine("Perimetr of triangle = {0}", resultFigura);
            Figure Figura1 = new Figure(ArrayOfPoint[0], ArrayOfPoint[1], ArrayOfPoint[2]);
            double resultFigura1 = Figura.CalculatePerimetrOfFigure();
            Console.WriteLine("Perimetr of square = {0}", resultFigura1);
        }
    }
}
class Point
{
    private int x;
    private int y;
    private string nameOfPoint;

    public int X
    {
        set
        {
            x = value;
        }
        get
        {
            return x;
        }
    }
    public int Y
    {
        set
        {
            y = value;
        }
        get
        {
            return y;
        }
    }
    public string NameOfPoint
    {
        set
        {
            nameOfPoint = value;
        }
        get
        {
            return nameOfPoint;
        }
    }
}
class Figure
{
    public Point[] ArrayPoint { get; set; }
    public string nameOfFigure; 

    public Figure(Point a, Point b, Point c)
    {
        Point[] arrayPoint = new Point[3];
        arrayPoint[0] = a;
        arrayPoint[1] = b;
        arrayPoint[2] = c;
    }
    public Figure(Point a, Point b, Point c, Point d)
    {
        Point[] arrayPoint = new Point[3];
        arrayPoint[0] = a;
        arrayPoint[1] = b;
        arrayPoint[2] = c;
        arrayPoint[3] = d;
    }
    public double CalculateFigurelength(Point side1, Point side2)
    {
        double figureLength = Math.Sqrt(Math.Pow(side1.X - side2.X, 2) + Math.Pow(side1.Y - side2.Y, 2));
        return figureLength;
    }
    public double CalculatePerimetrOfFigure()
    {
        double sum = 0;
        for (int i = 0; i < ArrayPoint.Length - 1; i++)
        {
            if (i == 0)
            {
                sum += CalculateFigurelength(ArrayPoint[ArrayPoint.Length - 1], ArrayPoint[0]);
            }

            sum += CalculateFigurelength(ArrayPoint[i], ArrayPoint[i + 1]);
        }
        return sum;
    }
}

// я не знаю как это пофиксить, код отказывается работать, думал на этим минут 30...


/*
  Создайте программу, в которой создайте класс «Точка» – для описания координат точки на 
  координатной прямой рис №1. В теле класса создайте следующие закрытые поля: целочисленное 
  поле для описания координаты точки X и целочисленное поле для описания координаты точки 
  Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и 
  set, а также конструктор класса, который будет инициализировать данные поля значениями 
  аргументов. 

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