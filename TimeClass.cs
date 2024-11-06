using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class TimeClass
    {

// Задание 2
// Создайте набор методов:
// ■ Метод для отображения текущего времени;
// ■ Метод для отображения текущей даты;
// ■ Метод для отображения текущего дня недели; ■ Метод для подсчёта площади треугольника;
// ■ Метод для подсчёта площади прямоугольника.
// Для реализации проекта используйте делегаты Action, Predicate, Func.

            public void ShowCurrentTime()
    {
        Console.WriteLine("Текущее время: " + DateTime.Now.ToString("HH:mm:ss"));
    }


    public void ShowCurrentDate()
    {
        Console.WriteLine("Текущая дата: " + DateTime.Now.ToString("yyyy-MM-dd"));
    }


    public void ShowCurrentDayOfWeek()
    {
        Console.WriteLine("Текущий день недели: " + DateTime.Now.DayOfWeek);
    }


    public double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }


    public double CalculateRectangleArea(double width, double height)
    {
        return width * height;
    }

 
    public bool AreValuesPositive(double a, double b)
    {
        return a > 0 && b > 0;
    }
    }
}