using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    class Student
    {
        private string _lastName;
        private string _firstName;
        private string _studentID;
        private string _gender;
        private string _dateOfBirth;
        private string _major;

        public Student()
        {
            _lastName = "unknown";
            _firstName = "unknown";
            _studentID = "M00000000";
            _gender = "unknown";
            _dateOfBirth = "01/01/1900";
            _major = "undecided";
        }

        public Student(string lastName, string firstName, string studentID)
        {
            _lastName = lastName;
            _firstName = firstName;
            _studentID = studentID;
            _gender = "unknown";
            _dateOfBirth = "01/01/1900";
            _major = "undecided";
        }

        public Student(string lastName, string firstName, string studentID, string gender, string dateOfBirth, string major)
        {
            _lastName = lastName;
            _firstName = firstName;
            _studentID = studentID;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _major = major;
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }

        public string printStudentInfo()
        {
            string desc = $"{FirstName} {LastName} ({Gender}) \n{StudentID} {Major} \nBorn: {DateOfBirth}";
            return desc;
        }
    }
}
