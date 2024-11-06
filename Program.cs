// See https://aka.ms/new-console-template for more information

using hw;

  MathClass clss = new MathClass();
  clss.Print();


  Arrays[] getArray = 
            {
                clss.GetEvenNumbers,
                clss.GetOddNumbers,
                clss.GetPrimeNumbers,
                clss.GetFibonacciNumbers
            };

          string[] descriptions = { "Чётные числа:", "Нечётные числа:", "Простые числа:", "Числа Фибоначчи:" };

            for (int i = 0; i < getArray.Length; i++)
            {
                Console.WriteLine(descriptions[i]);
                int[] result = getArray[i].Invoke();
                foreach (var num in result)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }



TimeClass time = new TimeClass();
Action showTime = time.ShowCurrentTime;
Action showDate = time.ShowCurrentDate;
Action showDay = time.ShowCurrentDayOfWeek;


showTime();
showDate();
showDay();




Predicate<double> isPositive = value => value > 0;
Func<double, double, double> calculateTriangleArea = time.CalculateTriangleArea;

double baseLength = 5;
double height = 10;

if (isPositive(baseLength) && isPositive(height))
{
    double triangleArea = calculateTriangleArea(baseLength, height);
    Console.WriteLine($"Площадь треугольника: {triangleArea}");
}
else
{
    Console.WriteLine("Значения для вычисления площади должны быть положительными.");
}