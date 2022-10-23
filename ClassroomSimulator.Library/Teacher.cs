using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomSimulator.Library
{
    public class Teacher
    {
        private string _newName;
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
