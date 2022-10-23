using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomSimulator.Library
{
    public class Teacher : Person
    {
        private List<Student> _students;
        public Teacher(string name) : base(name)
        {
            
        }

        public void GiveLecture()
        {
            string lecutre = "Wyklad o dziedziczeniu";
        }

        public void AddStudents(List<Student> students)
        {
            _students = students;
        }
    }
}
