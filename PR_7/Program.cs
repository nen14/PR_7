//**************************************
//* Практическая работа №7             *
//* Выполнил: Щур А.В.,группа 2-ИСПД   *
//* Задание:Практическая работа 7      *
//**************************************

using System;
using System.Linq.Expressions;

namespace SimpleGymCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество посетителей спортзала: ");
                uint n = UInt32.Parse(Console.ReadLine());

                double total = 0;
                const double rate = 500; // цена за час

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Часы для посетителя {i + 1}: ");
                    double hours = double.Parse(Console.ReadLine());
                    total += hours * rate;
                }

                Console.WriteLine($"\nОбщая сумма за день: {total} руб.");
                Console.ReadKey();
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fex.Message);
                Console.ResetColor();
            }
            catch (OverflowException oex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(oex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
