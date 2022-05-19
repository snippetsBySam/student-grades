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
        private static char[] grades = {'A', 'B', 'C', 'D', 'E', 'F' };
        private static int[] groups = { 1, 2, 3, 4, 5 };

        private string secretNickName { get; } 
        public Student(string name, char grade, int group) =>
            (_name, Grade, _group, secretNickName) = (name, grade, group, "MySecretNickName");

        public string Name
        {
            get{ return _name; }
        }
        public char Grade
        {
            get { return _grade; }
            private set
            {
                if (grades.Contains(value))
                {
                    _grade = value;
                }
                else
                {
                    _grade = 'N';
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
                    _group = 0;
                }
            }
        }
        public void Upgrade()
        {

        }
        public void Downgrade()
        {

        }
    }
}
