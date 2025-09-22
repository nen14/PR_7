//**************************************
//* Практическая работа №7             *
//* Выполнил: Щур А.В.,группа 2-ИСПД   *
//* Задание:Практическая работа 7      *
//**************************************

using System;

namespace SimpleGymCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество посетителей спортзала: ");
            int n = int.Parse(Console.ReadLine());
            
            double total = 0;
            const double rate = 500; // цена за час
            
            // Цикл с параметром for
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Часы для посетителя {i+1}: ");
                double hours = double.Parse(Console.ReadLine());
                total += hours * rate;
            }
            
            Console.WriteLine($"\nОбщая сумма за день: {total} руб.");
            Console.ReadKey();
        }
    }
}