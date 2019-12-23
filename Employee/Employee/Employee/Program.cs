using System;
using System.Collections.Generic;

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


                BaseClass alex = new BaseClass("Alex", "Alexeev", JobPosition.Boss);
                Calkulation.TryGetValue(JobPosition.Boss, out var func);
                Console.WriteLine(func(5000,2.3));
            }

        
    }
}
