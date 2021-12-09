using System;

namespace Laba_2_individual_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Индивидуалььное задание 1
            /*Console.WriteLine("Введите координаты точки по оси x и y, программа выведет номер четверти, в которой находится точка");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x>0 && y>0)
            {
                Console.WriteLine($"Точка ({x},{y}) находится в первой четверти");
            } else
                if (x<0 && y>0)
            {
                Console.WriteLine($"Точка ({x},{y}) находится во второй четверти");
            } else
                if (x<0 && y<0)
            {
                Console.WriteLine($"Точка ({x},{y}) находится в третей четверти");
            } else
                if  ( x>0 && y<0)
            {
                Console.WriteLine($"Точка ({x},{y}) находится в четвёртой четверти");
            } else
                Console.WriteLine("0");*/




            //Индивидуальное задание 2
            Console.WriteLine("Введите число от 1 до 10000");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 10000)
            {
                Console.WriteLine("Ошибка ввода. Введите число из промежутка: от 1 до 10000");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                if ((n / i) * i == n && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
