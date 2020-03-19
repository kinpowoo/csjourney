using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Person
    {
        private string name;
        private int age;
        private string sex;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
