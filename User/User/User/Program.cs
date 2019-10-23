<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User("User123", "Alex", "Ivanov", 30);
            person.Information();

            Console.WriteLine(new string ('-', 50));

            User secondperson = new User("Ivan 12", "Ivan", "Petrov", 25);
            secondperson.Information();
            
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User("User123", "Alex", "Ivanov", 30);
            person.Information();

            Console.WriteLine(new string ('-', 50));

            User secondperson = new User("Ivan 12", "Ivan", "Petrov", 25);
            secondperson.Information();
            
        }
    }
}
>>>>>>> 36d7011956f29c934d2c0045708541642a155a29
