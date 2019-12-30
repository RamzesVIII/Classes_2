using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public enum JobPosition
    {
        Programmer = 1,
        Boss = 2,
        ExtraBoss,
        Engeneer
    }
    public class BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public JobPosition Position { get; set; }
        public int Years { get; set; }
        public int Salary { get; set; }
        public double Koef { get; set; }

        

        public BaseClass(string firstName, string lastName, JobPosition position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public BaseClass() { }

        
    }
}
