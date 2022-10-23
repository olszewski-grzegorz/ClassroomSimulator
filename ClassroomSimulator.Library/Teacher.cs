using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomSimulator.Library
{
    public class Teacher
    {
        public string Name
        {
            get;
            private set;

        }
        public Teacher(string name)
        {
            Name = name;
        }

    }
}
