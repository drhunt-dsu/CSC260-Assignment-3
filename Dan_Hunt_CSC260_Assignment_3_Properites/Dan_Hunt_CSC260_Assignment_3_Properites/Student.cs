//Dan Hunt
//daniel.hunt@trojans.dsu.edu
//CSC260 Assignment 3

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace Dan_Hunt_CSC260_Assignment_3_Properties
{
    class Student
    {
        #region private backing fields
        private readonly int _id;
        private string _name;
        private string _major;
        private DateTime? _startDate;
        private DateTime? _anticipatedGraduationDate;
        private string _mailingAddress;
        private string? _stateProvince;
        private string _country;
        private string _email;
        private string _phone;
        #endregion

        #region Properties
        public int Id => _id;//Read Only (no setter)

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine($"Student {Id} _name set to {_name}");
            }
        }

        public string Major
        {
            get => _major;
            set
            {
                _major = value;
                Console.WriteLine($"Student {Id} _major set to {_major}");
            }
        }

        public DateTime? StartDate
        {
            get => _startDate;
            set
            {
                //We don't want to have a graduation date before the start date
                if (value > _anticipatedGraduationDate)
                {
                    Console.WriteLine($"Student {_id} Start Date {value} cannot be after Graduation Date {AnticipatedGraduationDate}");
                }
                else
                {
                    _startDate = value;
                    Console.WriteLine($"Student {Id} _startDate set to {_startDate}");
                }
            }
        }

        public DateTime? AnticipatedGraduationDate
        {
            get => _anticipatedGraduationDate;
            set
            {
                //We don't want to have a graduation date before the start date
                if (value < _startDate)
                {
                    Console.WriteLine($"Student {_id} Graduation {value} cannot be before date {AnticipatedGraduationDate}");
                }
                else
                {
                    _anticipatedGraduationDate = value;
                    Console.WriteLine($"Student {Id} _anticipatedGraduationDate set to {_anticipatedGraduationDate}");
                }
            }
        }

        public string MailingAddress
        {
            get => _mailingAddress;
            set
            {
                _mailingAddress = value;
                Console.WriteLine($"Student {Id} _mailingAddress set to {_mailingAddress}");
            }
        }

        public string? StateProvince
        {
            get => _stateProvince;
            set
            {
                _stateProvince = value;
                Console.WriteLine($"Student {Id} _stateProvince set to {_stateProvince}");
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                Console.WriteLine($"Student {Id} _country set to {_country}");
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                Console.WriteLine($"Student {Id} _email set to {_email}");
            } 
        }

        public string Phone
        {
            get => _phone;
            set
            {
                try
                {
                    new PhoneAttribute().Validate(value, value);
                    _phone = value;
                    Console.WriteLine($"Student {Id} _phone set to {_phone}");
                }
                catch(ValidationException e)
                {
                    Console.WriteLine($"Unable to set phone number of \"{value}\" for student {_id} : {e.Message}");
                }
            }
        }

        #endregion

        #region Constructors
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
        #endregion


        /*Instructions:
            Historically, systems like WebAdvisor and Banner have allowed students to restrict the viewing of their personal information.
                Implement this system here, by ensuring the getters of properties check for this value before returning student information. Student ID and Name are exempt from needing to be checked.
        */
    }
}
