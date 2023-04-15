using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Aggregation_and_Containment
{
    internal class SchoolProgram
    {
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor;
        List<Student> _classsRoster;

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            ClassName = className;
            ClassNumber = classNumber;
            RoomNumber = roomNumber;
            Instructor = instructor;
            _classsRoster = new List<Student>();    
        }

        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        internal Instructor Instructor { get => _instructor; set => _instructor = value; }
        internal List<Student> ClasssRoster { get => _classsRoster; }
        public void AddStudent(Student student)
        { 
             _classsRoster.Add(student);
        }
        public void AddStudent(string firstName, string lastName, int csiGrade,int genEdGrade)
        {
        Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
            _classsRoster.Add(student);
        }
        public override string ToString()
        {
            return $"{_className} {_classNumber} - Room: {_roomNumber} - Instructor: {_instructor} - Number of Students: {_classsRoster.Count}";
        }
    }
}
