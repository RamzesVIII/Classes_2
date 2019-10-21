using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        string firstname, lastname, position;
        int years;
        double cash, tax;

        public Employee (string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        
        public void salary ( Employee worker)
        {
            Console.WriteLine("Введите должность сотрудника ");
            position = Console.ReadLine();

            switch (position)
            {
                case "enginere":
                    Console.WriteLine("Введите стаж работы сотрудника ");
                    years =Convert.ToInt32(Console.ReadLine());
                    if (0 < years && years <= 5)
                    {
                        cash = 1000;
                        tax = cash * 0.13;
                    }
                    if (5 < years && years <= 10)
                    {
                        cash = 1200;
                        tax = cash * 0.13;
                    }
                    if (10 < years && years <= 15)
                    {
                        cash = 1500;
                        tax = cash * 0.13;
                    }
                    Console.WriteLine(" Сотрудник - {0} {1} \n оклад = {2} \n налоговый сбор составляет - {3}",
                        firstname,lastname,cash,tax);
                    break;
                case "programmer":
                    Console.WriteLine("Введите стаж работы сотрудника ");
                    years = Convert.ToInt32(Console.ReadLine());
                    if (0 < years && years <= 5)
                    {
                        cash = 2000;
                        tax = cash * 0.13;
                    }
                    if (5 < years && years <= 10)
                    {
                        cash = 2200;
                        tax = cash * 0.13;
                    }
                    if (10 < years && years <= 15)
                    {
                        cash = 2500;
                        tax = cash * 0.13;
                    }
                    Console.WriteLine(" Сотрудник - {0} {1} \n оклад = {2} \n налоговый сбор составляет - {3}",
                        firstname, lastname, cash, tax);
                    break;
                case "manager":
                    Console.WriteLine("Введите стаж работы сотрудника ");
                    years = Convert.ToInt32(Console.ReadLine());
                    if (0 < years && years <= 5)
                    {
                        cash = 1500;
                        tax = cash * 0.13;
                    }
                    if (5 < years && years <= 10)
                    {
                        cash = 1700;
                        tax = cash * 0.13;
                    }
                    if (10 < years && years <= 15)
                    {
                        cash = 2000;
                        tax = cash * 0.13;
                    }
                    Console.WriteLine(" Сотрудник - {0} {1} \n оклад = {2} \n налоговый сбор составляет - {3}",
                        firstname, lastname, cash, tax);
                    break;
                default:
                    break;
            }
        }

    }
}
