using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    delegate int[] Arrays();
    public class MathClass
    {
// Задание 1
// Создайте набор методов для работы с массивами:
// ■ Метод для получения всех четных чисел в массиве;
// ■ Метод для получения всех нечетных чисел в массиве;
// ■ Метод для получения всех простых чисел в массиве;
// ■ МетоддляполучениявсехчиселФибоначчивмассиве.
// Используйте механизмы делегатов.
        public int[] Array {get; set;}

        public MathClass(int[] array){
            Array = array;
        }
         
         public MathClass(){
            int length = 10;
            Array = new int[length];
            Random random = new Random();

            for(int i = 0; i < length; i++){
                Array[i] = random.Next(0, 11);
            }
         }


         public void Print(){
            for(int i = 0; i < Array.Length; i++){
                Console.Write(Array[i] + " ");
                }
         }

         public int[] GetEvenNumbers(){
            int count = 0;
            int index = 0;
            foreach(int element in Array){
                if(element % 2 == 0){
                    count++;
                }
            }
            int[] array = new int[count];
            foreach(int element in Array){
                if(element % 2 == 0){
                array[index++] = element;
            }
            }
            return array;
         }


                 public int[] GetOddNumbers(){
            int count = 0;
            int index = 0;
            foreach(int element in Array){
                if(element % 2 != 0){
                    count++;
                }
            }
            int[] array = new int[count];
            foreach(int element in Array){
                if(element % 2 != 0){
                array[index++] = element;
            }
            }
            return array;
         }


          public int[] GetPrimeNumbers()
        {
            int count = 0;
            foreach (var num in Array)
            {
                if (IsPrime(num)) count++;
            }

            int[] primeNumbers = new int[count];
            int index = 0;
            foreach (var num in Array)
            {
                if (IsPrime(num)) primeNumbers[index++] = num;
            }
            return primeNumbers;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }


        public int[] GetFibonacciNumbers()
        {
            int count = 0;
            foreach (var num in Array)
            {
                if (IsFibonacci(num)) count++;
            }

            int[] fibonacciNumbers = new int[count];
            int index = 0;
            foreach (var num in Array)
            {
                if (IsFibonacci(num)) fibonacciNumbers[index++] = num;
            }
            return fibonacciNumbers;
        }

        private bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            while (b < n)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == n || n == 0;
        }
    
         
    }
}