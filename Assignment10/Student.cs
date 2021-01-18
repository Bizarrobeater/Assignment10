using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    // Student class for 10ø0 and 10ø1
    class Student
    {
        public string Name { get; private set; }

        public Student(string name)
        {
            Name = name;
        }

        public void SetValue(string name) => Name = name;

        public string GetValue() => Name;
    }
}
