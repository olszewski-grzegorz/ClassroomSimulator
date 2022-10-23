using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomSimulator.Library
{
    public class Student : Person
    {
        private List<string> _notes;


        public Student(string name) : base(name)
        {
            _notes = new List<string>();
        }

        public void AddNote(string note)
        {
            _notes.Add(note);
        }
    }
}
