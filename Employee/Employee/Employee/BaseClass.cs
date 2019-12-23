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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public JobPosition Position { get; private set; }
        

        public BaseClass(string firstName, string lastName, JobPosition position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

    }
}
