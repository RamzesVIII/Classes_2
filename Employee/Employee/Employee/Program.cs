using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee
{
    class Program
    {
        private Func<double, double, double> fufu = (okl, koe) => { return (okl * koe) + okl; };
        

            static void Main(string[] args)
            {
                Dictionary<JobPosition, Func<double, double, double>> Calkulation = new Dictionary<JobPosition, Func<double, double, double>>();
                Calkulation.Add(JobPosition.Boss, (okl, koe) => { return (okl * koe) + okl; });
                Calkulation.Add(JobPosition.ExtraBoss, (okl, koe) => { return (okl * koe) + okl; });
                Calkulation.Add(JobPosition.Programmer, (okl, koe) => { return (okl * koe) + okl; });
                Calkulation.Add(JobPosition.Engeneer, (okl, koe) => { return (okl * koe) + okl; });

                var employeese = new List<BaseClass>
                {
                    new BaseClass()
                    {
                        FirstName = "Ivan",
                        LastName = "Ivanov",
                        Position = JobPosition.ExtraBoss,
                        Years = 10,
                        Salary = 5000,
                        Koef = 1.3
                    },
                    new BaseClass()
                    {
                        FirstName = "Anton",
                        LastName = "Ivanov",
                        Position = JobPosition.Boss,
                        Years = 7,
                        Salary = 3000,
                        Koef = 0.7
                    },
                    new BaseClass()
                    {
                        FirstName = "Roman",
                        LastName = "Antonov",
                        Position = JobPosition.Programmer,
                        Years = 1,
                        Salary = 500,
                        Koef = 0.3
                    }

                };

                BaseClass alex = new BaseClass("Alex", "Alexeev", JobPosition.Boss);
                Calkulation.TryGetValue(JobPosition.Boss, out var func);
                Console.WriteLine(func(5000,2.3));

                employeese = employeese.OrderBy(last => last.LastName).ThenBy(first => first.FirstName).ToList<BaseClass>();

                foreach (var VARIABLE in employeese)
                {
                    Console.WriteLine($"{VARIABLE.LastName}, {VARIABLE.FirstName}");
                    Console.WriteLine(func(VARIABLE.Salary,VARIABLE.Koef));
                Console.WriteLine(func(VARIABLE.Salary, VARIABLE.Koef) * 0.13);
            }
            }

        
    }
}
