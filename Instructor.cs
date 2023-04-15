using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Aggregation_and_Containment
{
    internal class Instructor
    {
        string _firstName;
        string _lastName;

        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public override string ToString()
        {
            return $"Instructor: {_firstName} {_lastName}";
        }
    }
}
