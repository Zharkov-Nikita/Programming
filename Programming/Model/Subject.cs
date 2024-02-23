using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        private string _name;
        private string _teacher;
        private int _grade;

        public string Name { get; set; }
        public string Teacher { get; set; }

        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value <= 0 || value > 5)
                {
                    throw new ArgumentException();
                }
                _grade = value;
            }
        }

        public Subject(string name, string teacher, int grade)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }
    }
}
