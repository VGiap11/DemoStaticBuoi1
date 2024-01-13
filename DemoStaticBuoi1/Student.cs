using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticBuoi1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public int Age { get; set; }
        public string Description { get; set; }

        public Student() { }
        public Student(int id, string name, int age, string description)
        {
            Id = id;
            Name = name;
            Age = age;
            Description = description;
        }
    }
}
