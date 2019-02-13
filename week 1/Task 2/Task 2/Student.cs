using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string Id;
        public int YeartOFStudy;
        public Student(string name, string id) // Constructor which will take two parameters
        {
            this.name = name;
            this.Id = id;
        }
        public string GetName() // The Method which returns name of the Student
        {
            return name;
        }
        public string GetId() // The Method which returns ID of the Student
        {
            return Id;
        }
        public int GetYearOfStudy()  // The Method which increases Year of the Student
        {
            return ++YeartOFStudy;
        }
    }
}
