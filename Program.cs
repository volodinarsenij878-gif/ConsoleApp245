using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program86
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите выслугу лет военнослужащего (целое неотрицательное число): ");

            if (int.TryParse(Console.ReadLine(), out int years) && years >= 0)
            {
                // Вычисление бонуса с помощью if-else конструкции
                double bonusPercent = 0;

                if (years < 10)
                {
                    bonusPercent = 0;
                }
                else if (years < 15)
                {
                    bonusPercent = 10;
                }
                else if (years < 20)
                {
                    bonusPercent = 15;
                }
                else if (years < 25)
                {
                    bonusPercent = 20;
                }
                else
                {
                    bonusPercent = 30;
                }

                Console.WriteLine($"Процент пенсионной надбавки: {bonusPercent}%");
            }
            else
            {
                Console.WriteLine("Ошибка: укажите неотрицательное целое число.");
            }
        }
    }
}