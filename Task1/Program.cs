using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа,
            а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение,
            4 – частное). После этого на консоль выводится ответ. Используйте обработку исключений
            для защиты от ввода некорректных данных.
             */

            int x = 0;
            int y = 0;
            int operation = 0;
            double result = 0;
            bool noErrors = true;
            Console.WriteLine("Калькулятор\n");

            Console.Write("Введите целое число: X = ");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
                noErrors = false;
            }

            if (noErrors)
            {
                Console.Write("Введите целое число: Y = ");
                try
                {
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                    noErrors = false;
                }
            }

            if (noErrors)
            {
                Console.WriteLine("Введите код операции:\n" +
                                      "\t1 - сложение\n" +
                                      "\t2 - вычитание\n" +
                                      "\t3 - произведение\n" +
                                      "\t4 - частное");
                Console.Write("Ваш выбор: ");
                try
                {
                    operation = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                    noErrors = false;
                }
            }

            if (noErrors)
            {
                switch (operation)
                {
                    case 1:
                        result = x + y;
                        break;

                    case 2:
                        result = x - y;
                        break;

                    case 3:
                        result = x * y;
                        break;

                    case 4:
                        result = Convert.ToDouble(x) / Convert.ToDouble(y);
                        break;

                    default:
                        Console.WriteLine("Ошибка! " + "Нет операции с указанным номером.");
                        noErrors = false;
                        break;
                }
            }

            if (noErrors)
            {
                Console.WriteLine("Результат = {0}", result);
            }
            else
            {
                Console.WriteLine("Выполнение программы прервано.");
            }

            Console.ReadKey();
        }
    }
}
