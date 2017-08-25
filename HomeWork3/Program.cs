using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 4.5
  В программе определены два числа, определяющие нижний и верхний пороговые уровни на цену товара.
  Ввести с клавиатуры новую цену товара.
  Реализовать следующие условия: 
  если цена поднялась выше верхнего значения, то сообщить об этом трейдеру, 
  если цена опустилась ниже нежнего порога,  то сообщить об этом трейдеру, 
  в остальных случаях не осуществлять никаких действий.
  Предложить два варианта(последовательный и вложенный if) */

            /*
              int prL = 10, prU = 20;

              Console.WriteLine("Lower price: " + prL);
              Console.WriteLine("Upper price: " + prU);
              Console.Write("What is new price? - ");

              double prN = double.Parse(Console.ReadLine());
              if (prN < prL)
              {
                  Console.WriteLine("\nNew price ({0}) is LESS than Upper price ({1}). Call a trader!", prN, prL);
              }
                 else if (prN > prU)
              {
                  Console.WriteLine("\nNew price ({0}) is MORE than Upper price ({1}). Call a trader!", prN, prU);
              }
              else
                  {
                      Console.WriteLine("\nNew price in the limit!");
                  }
                  */

            /*
            int prL = 10, prU = 20;

            Console.WriteLine("Lower price: " + prL);
            Console.WriteLine("Upper price: " + prU);
            Console.Write("What is new price? - ");

            double prN = double.Parse(Console.ReadLine());

            if (prN < prL || prN > prU)
            {
                Console.WriteLine("\nThe new price is NOT in the limit. Call a treder!");
            }
            else
            {
                Console.WriteLine("\nThe new price in the limit!");
            }
            */

            /* Задача 4.6
  Написать программу -калькулятор.Пользователь вводит два числа и то действие, 
  которое нужно совершить (+, -, *, /, %)
  Вывести полученный результат на экран.
  Реализовать два варианта(с оператором if и case) */

            /*
            Console.Write("Enter the number: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Enter action: \n(+) (-) (*) (/) (%) : ");
            string act = Console.ReadLine();

            if (act == "+")
            {
                Console.WriteLine("\nResult: " + (n1 + n2));
            }
            if (act == "-")
            {
                Console.WriteLine("\nResult: " + (n1 - n2));
            }
            if (act == "*")
            {
                Console.WriteLine("\nResult: " + (n1 * n2));
            }
            if (act == "/")
            {
                Console.WriteLine("\nResult: " + (n1 / n2));
            }
            if (act == "%")
            {
                if (n1 >= n2)
                {
                    Console.WriteLine("\nResult: " + (n1 % n2));
                }
                else
                {
                    Console.WriteLine("\nResult: " + (n2 % n1));

                }
            }
            */
            /* 
            Console.Write("Enter the number: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Enter action:\n (+) (-) (*) (/) (%) : ");
            string ch = Console.ReadLine();
            
            switch (ch)
            {
                case "+":
                    {
                        Console.WriteLine("\nResult: " + (n1 + n2));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("\nResult: " + (n1 - n2));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("\nResult: " + (n1 * n2));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("\nResult: " + (n1 / n2));
                        break;
                    }
                case "%":
                    {
                        if (n1 < n2)
                        {
                            Console.WriteLine("\nResult: " + (n2 % n1));
                        }
                        else
                        {
                            Console.WriteLine("\nResult: " + (n1 % n2));
                        }
                        break;
                     }
            }

            Console.ReadKey();*/

            /* 3адача 4.7
   Ввести с клавиатуры данные о трех машинах:
  (Название, максимальная скорость, количество литров на 100 км.)
   Вывести на экран две таблицы сравнения:
      1) по максимальной скорости
   2) по количеству литров на 100 км. */

            Console.WriteLine("\tNow we will compare thre cars.\n");

            Console.Write("Write the name of the car_1: ");
            string n1 = Console.ReadLine();
            Console.Write("Write speed of {0} (km/h): ", n1);
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Write the petrol consumption of {0} (l/100km): ", n1);
            double c1 = double.Parse(Console.ReadLine());

            Console.Write("\nWrite the name of the car_2: ");
            string n2 = Console.ReadLine();
            Console.Write("Write speed of {0} (km/h): ", n2);
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Write the petrol consumption of {0} (l/100km): ", n2);
            double c2 = double.Parse(Console.ReadLine());

            Console.Write("\nWrite the name of the car_3: ");
            string n3 = Console.ReadLine();
            Console.Write("Write speed of {0} (km/h): ", n3);
            int s3 = int.Parse(Console.ReadLine());
            Console.Write("Write the petrol consumption of {0} (l/100km): ", n3);
            double c3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nSpeed comparison table ");

            if (s1 > s2)
            {
                if (s2 > s3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n1, n2, n3);
                    Console.WriteLine("\n{0}\t{1}\t{2}", s1, s2, s3);
                } else if (s2 < s3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n1, n3, n2);
                    Console.WriteLine("\n{0}\t{1}\t{2}", s1, s3, s2);
                } else
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n3, n1, n2);
                    Console.WriteLine("\n{0}\t{1}\t{2}", s3, s1, s2);
                }
            } 
            if (s2 > s1)
            {
                if (s1 > s3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n2, n1, n3);
                    Console.WriteLine("\n{0}\t{1}\t{2}", s2, s1, s3);
                } else  if (s1 < s3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n2, n3, n1);
                    Console.WriteLine("\n{0}\t{1}\t{2}", s2, s3, s1);
                }
                else
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n3, n2, n1);
                    Console.WriteLine("\n{0}\t{1}\t{2}", s3, s2, s1);
                }
            }
           

            Console.WriteLine("\n\nComparison table for gasoline consumption ");
            if (c1 > c2)
            {
                if (c2 > c3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n1, n2, n3);
                    Console.WriteLine("\n{0}\t{1}\t{2}", c1, c2, c3);
                }
                else if (c2 < c3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n1, n3, n2);
                    Console.WriteLine("\n{0}\t{1}\t{2}", c1, c3, c2);
                }
                else
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n3, n1, n2);
                    Console.WriteLine("\n{0}\t{1}\t{2}", c3, c1, c2);
                }
            }
            if (c2 > c1)
            {
                if (c1 > c3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n2, n1, n3);
                    Console.WriteLine("\n{0}\t{1}\t{2}", c2, c1, c3);
                }
                else if (c1 < c3)
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n2, n3, n1);
                    Console.WriteLine("\n{0}\t{1}\t{2}", c2, c3, c1);
                }
                else
                {
                    Console.WriteLine("\n{0}\t{1}\t{2}", n3, n2, n1);
                    Console.WriteLine("\n{0}\t{1}\t{2}", c3, c2, c1);
                }
            }
            
            Console.ReadLine();
        }
    }
}
