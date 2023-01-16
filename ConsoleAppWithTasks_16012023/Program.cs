using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithTasks_16012023
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Запросить имя пользователя. Вывести Hello, [имя пользователя].
            Task1();
            /*2. Запросить у пользователя два целых числа и сохранить в двух переменных. Вывести значения.
             * Обменять значения переменных: например, если в переменной x было записано число 3,
             * а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5.
             * Вывести значения после обмена.
             */
            Task2();
            //3. Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.
            Task3();
            Console.ReadLine();
        }
        static void Task1()
        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}");
        }
        static void Task2()
        {
            Console.Write("Введите целое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Первое число: {num1} Второе число: {num2}");

            int temp = num2;
            num2 = num1;
            num1 = temp;
            Console.WriteLine($"Первое число: {num1} Второе число: {num2}");
        }
        static void Task3()
        {
            Console.Write("Введите целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string numString = num.ToString();
            Console.WriteLine($"Количество цифр числа {num} = {numString.Length}");

        }
    }
}

