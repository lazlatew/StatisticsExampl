﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsExampl
{
    internal class Person
    {
        //svoistva
        public string Name { get; set; }
        public int Age { get; set; }

        // Konstruktor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
