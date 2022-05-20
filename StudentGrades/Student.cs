using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class Student
    {
        private string _name;
        private char _grade;
        private int _group;
        private string secretNickName;
        private static char[] grades = {'A', 'B', 'C', 'D', 'E', 'F' };
        private static int[] groups = { 1, 2, 3, 4, 5 };

         
        public Student(string name, char grade, int group) =>
            (_name, Grade, Group, secretNickName) = (name, grade, group, "MySecretNickName");

        public string Name
        {
            get{ return _name; }
        }
        public char Grade
        {
            get { return _grade; }
            private set
            {
                if (grades.Contains(char.ToUpper(value)))
                {
                    _grade = char.ToUpper(value);
                }
                else
                {
                    throw new ArgumentException($"\"{value}\" is not a valid grade"); ;
                }
            }
        }
        public int Group
        {
            get { return _group; }
            private set
            {
                if (groups.Contains(value))
                {
                    _group = value;
                }
                else
                {
                    throw new ArgumentException($"\"{value}\" is not a valid group");
                }
            }
        }
        public void Upgrade()
        {
            if(_grade > grades[0])
            _grade--;
        }
        public void Downgrade()
        {
            if (_grade < grades.Last())
                _grade++;
        }
    }
}
