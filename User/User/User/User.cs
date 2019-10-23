<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        private string login;
        private string firstname;
        private string lastname;
        private int age;
        private readonly DateTime date;

        public string Login
        { get; set; }
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public string Age
        { get; set; }

        public User ()
        {
            date = DateTime.Now;
            
        }

        public User (string login, string firstname, string lastname, int age)
        {
            this.login = login;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            date = DateTime.Now;
        }

        public void Information ()
        {
            Console.WriteLine(" User login - {0} \n User first name - {1} \n User last name - {2} \n" +
                " User age - {3} \n Date - {4}", login,firstname,lastname,age,date );
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
    class User
    {
        private string login;
        private string firstname;
        private string lastname;
        private int age;
        private readonly DateTime date;

        public string Login
        { get; set; }
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public string Age
        { get; set; }

        public User ()
        {
            date = DateTime.Now;
            
        }

        public User (string login, string firstname, string lastname, int age)
        {
            this.login = login;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            date = DateTime.Now;
        }

        public void Information ()
        {
            Console.WriteLine(" User login - {0} \n User first name - {1} \n User last name - {2} \n" +
                " User age - {3} \n Date - {4}", login,firstname,lastname,age,date );
        }


    }
}
>>>>>>> 36d7011956f29c934d2c0045708541642a155a29
