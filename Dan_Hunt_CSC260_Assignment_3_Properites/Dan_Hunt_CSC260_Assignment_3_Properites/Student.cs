//Dan Hunt
//daniel.hunt@trojans.dsu.edu
//CSC260 Assignment 3

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dan_Hunt_CSC260_Assignment_3_Properites
{
    class Student
    {
        private readonly int _id;
        private string _name;
        private string _major;
        private DateTime _startDate;
        private DateTime _anticipatedGraduationDate;
        private string _mailingAddress;
        private string? _stateProvince;
        private string _country;
        private string _email;
        private PhoneAttribute _phone;

        #region Properties
        public int Id => _id;//Read Only (no setter)

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine($"Student {Id} _name set to {value}");
            }
        }

        public string Major
        {
            get => _major;
            set
            {
                _major = value;
                Console.WriteLine($"Student {Id} _major set to {value}");
            }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                Console.WriteLine($"Student {Id} _startDate set to {value}");
            }
        }

        public DateTime AnticipatedGraduationDate
        {
            get => _anticipatedGraduationDate;
            set
            {
                _anticipatedGraduationDate = value;
                Console.WriteLine($"Student {Id} _anticipatedGraduationDate set to {value}");
            }
        }

        public string MailingAddress
        {
            get => _mailingAddress;
            set
            {
                _mailingAddress = value;
                Console.WriteLine($"Student {Id} _mailingAddress set to {value}");
            }
        }

        public string? StateProvince
        {
            get => _stateProvince;
            set
            {
                _stateProvince = value;
                Console.WriteLine($"Student {Id} _stateProvince set to {value}");
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                Console.WriteLine($"Student {Id} _country set to {value}");
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                Console.WriteLine($"Student {Id} _email set to {value}");
            } 
        }

        public PhoneAttribute Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Console.WriteLine($"Student {Id} _phone set to {value}");
            }
        }

        #endregion

        //default constructor
        public Student()
        {
            _id= -1;
            Name = "John Doe";
        }

        //parameterized constructor
        public Student(int id)
        {
            _id = id;
        }

        /*Instructions:
        1) Log every instance of writing of a private field within a property setter. Before the program exits, output the activity log to the screen. 
                    Set the value of each property of each student to facilitate testing and operation of this logging functionality.
    
        2) Choose at least one property for students, and make sure its setter has logic in it other than the default auto property setter code.
                Logging is not counted for these requirements. See the WatchDogAbility example from Chapter 3 slides/text.
                Historically, systems like WebAdvisor and Banner have allowed students to restrict the viewing of their personal information.
                Implement this system here, by ensuring the getters of properties check for this value before returning student information. Student ID and Name are exempt from needing to be checked.
        */



    }
}
