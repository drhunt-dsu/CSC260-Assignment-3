//Dan Hunt
//daniel.hunt@trojans.dsu.edu
//CSC260 Assignment 3 - Properties & Fields

using System;
using System.ComponentModel.DataAnnotations;

namespace Dan_Hunt_CSC260_Assignment_3_Properties
{
    class Student
    {
        public static string AccessError = "You do not have access to view this property";

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
        //Bool hasViewAccess is for this condition of the assignment:
        /*
         * Historically, systems like WebAdvisor and Banner have allowed students to restrict the viewing of their personal information.
            Implement this system here, by ensuring the getters of properties check for this value before returning student information. 
            Student ID and Name are exempt from needing to be checked.
         */
        private bool _hasViewAccess;
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
            get => _hasViewAccess ? _major : AccessError;
            set
            {
                _major = value;
                Console.WriteLine($"Student {Id} _major set to {_major}");
            }
        }

        public DateTime? StartDate
        {
            get => _hasViewAccess ? _startDate : null;
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
            get => _hasViewAccess ? _anticipatedGraduationDate : null;
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
            get => _hasViewAccess ? _mailingAddress : AccessError;
            set
            {
                _mailingAddress = value;
                Console.WriteLine($"Student {Id} _mailingAddress set to {_mailingAddress}");
            }
        }

        public string? StateProvince
        {
            get => _hasViewAccess ? _stateProvince : AccessError;
            set
            {
                _stateProvince = value;
                Console.WriteLine($"Student {Id} _stateProvince set to {_stateProvince}");
            }
        }

        public string Country
        {
            get => _hasViewAccess ? _country : AccessError;
            set
            {
                _country = value;
                Console.WriteLine($"Student {Id} _country set to {_country}");
            }
        }

        public string Email
        {
            get => _hasViewAccess ? _email : AccessError;
            set
            {
                _email = value;
                Console.WriteLine($"Student {Id} _email set to {_email}");
            } 
        }

        public string Phone
        {
            get => _hasViewAccess ? _phone : AccessError;
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

        public bool HasViewAccess
        {
            //Set only, no need to read
            set { _hasViewAccess = value; }
        }
        #endregion

        #region Constructors
        //default constructor
        public Student()
        {
            _id= -1;
            Name = "John Doe";
            _hasViewAccess = false;
        }

        /// <summary>
        /// parameterized constructor for creating a student with an ID
        /// Uses optional value of hasViewAccess which defaults to false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hasViewAccess"></param>
        public Student(int id, bool hasViewAccess = false)
        {
            _id = id;
            _hasViewAccess = hasViewAccess;
        }
        #endregion
    }
}