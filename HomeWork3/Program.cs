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

            Console.Write("Enter the number_1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number_2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Enter action:    +   -   *   /   : ");
            string act = Console.ReadLine();

            if (act == "+" )
            {
                Console.WriteLine("{0} + {1} = {2}", n1, n2, (n1 + n2));
            }
            if (act == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", n1, n2, (n1 - n2));
            }
            if (act == "*")
            {
                Console.WriteLine("{0} * {1} = {2}", n1, n2, (n1 * n2));
            }
            if (act == "/")
            {
                Console.WriteLine("{0} / {1} = {2}", n1, n2, (n1 / n2));
            }

            Console.ReadKey();
 
          
        }
    }
}
