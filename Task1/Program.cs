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

            Console.WriteLine("Калькулятор\n");

            double result;

            try
            {
                Console.Write("Введите целое число: X = ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите целое число: Y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции:\n" +
                                      "\t1 - сложение\n" +
                                      "\t2 - вычитание\n" +
                                      "\t3 - произведение\n" +
                                      "\t4 - частное");
                int operation = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ваш выбор: ");
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
                        throw new Exception(String.Format("Не существует операции с кодом {0}.", operation));
                }

                Console.WriteLine("Результат = {0}", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }  
            
            Console.ReadKey();
        }
    }
}
