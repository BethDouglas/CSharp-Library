using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._04_OverloadContructors
{
    class Person
    {
        public Person(string firstName, int age)
        {
            this.FirstName = firstName;
            this.Age = age;
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
