using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    /*Create a class Student having:

- two fields: age and name- check

- a constant field named MIN_AGE equal to 18 - check

- a constant field named MAX_AGE equal to 99 - check

- a full property named Age(validate for minimum input  MIN_AGE and maximum input MAX_AGE)-check

- a nullable automatic property named Mark

- a constructor with age and name parameters- check

- a readonly dynamic property named Info, combining name and age in one string*/


    class Student
    {

        private string _fullname;
        private int _age;
        private const int MIN_AGE = 18;
        private const int MAX_AGE = 99;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                    throw new ArgumentOutOfRangeException("The age is not valid for being a student.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Student(string fullname, int age)
        {
            _fullname = fullname;
            Age = age;
        }

       
        public int? Mark { get; set; }

        public string Info
        {
            get
            {
                return _fullname + " is " + _age + " years old.";
            }
        }


    }
}

