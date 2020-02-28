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
        #region Properties
        //These properties are auto-generated and implicitly include backing fields
        public int Id { get; } //Read Only (no setter)
        public string Name { get; set; }
        public string Major { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime AnticipatedGraduationDate { get; set; }
        public string MailingAddress { get; set; }
        public string? StateProvince { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public PhoneAttribute Phone { get; set; }
        #endregion

        //default constructor
        public Student()
        {
            Id = -1;
            Name = "John Doe";
        }

        //parameterized constructor
        public Student(int id)
        {
            Id = id;
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
