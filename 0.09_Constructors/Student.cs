using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Student
    {

        //Contructor 1
        public Student(string firstName)
        {
            this.FirstName = firstName;
        }
        //Contructor 2
        public Student(string lastName, int grade)
        {
            this.LastName = lastName;
            this.Grade = grade;
        }
        //Contructor 3
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        //Contructor 4
        public Student(string firstName, string lastName, int age, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

    }
}
