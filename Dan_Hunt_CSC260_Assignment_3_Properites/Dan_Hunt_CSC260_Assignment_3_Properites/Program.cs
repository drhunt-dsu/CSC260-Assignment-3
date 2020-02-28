//Dan Hunt
//daniel.hunt@trojans.dsu.edu
//CSC260 Assignment 3 - Properties & Fields
using System;

namespace Dan_Hunt_CSC260_Assignment_3_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Creating Default Student");
            var defaultStudent = new Student();
            Console.WriteLine("**** Create Student & Set All Properties");
            var korben = CreateExampleStudent();
            Console.WriteLine("**** Forced Error Tests ***");
            var invalidStudent = CreateForcedErrorStudent();
            Console.WriteLine("*** Output Student info with permission");
            korben.HasViewAccess = true;
            OutputAllInfoForStudent(korben);
            Console.WriteLine("*** Output Student info without permission ***");
            korben.HasViewAccess = false;
            OutputAllInfoForStudent(korben);
        }

        private static Student CreateExampleStudent()
        {
            var student = new Student(1997)
            {
                Name = "Korben Dallas",
                Major = "English and Bad English",
                MailingAddress = "5000 block Apt 281-53, New York",
                StateProvince = "NY",
                Country = "USA",
                Email = "kdallas@ZorgIndustries.com",
                Phone = "555-867-5309"
            };

            return student;
        }

        private static Student CreateForcedErrorStudent()
        {
            var validationStudent = new Student(23);
            
            var today = DateTime.Now;

            //check graduation before start
            validationStudent.StartDate = today;
            validationStudent.AnticipatedGraduationDate = today.AddDays(-1);

            //Check for start date after graduation date
            validationStudent.AnticipatedGraduationDate = today.AddDays(1);
            validationStudent.StartDate = today.AddDays(2);

            //Check for phone number validation
            validationStudent.Phone = "abc123";

            return validationStudent;
        }

        /// <summary>
        /// Outputs all student information that we have permission to view.
        /// </summary>
        /// <param name="student"></param>
        private static void OutputAllInfoForStudent(Student student)
        {
            //Bool hasAccess is for this condition of the assignment:
            /*
             * Historically, systems like WebAdvisor and Banner have allowed students to restrict the viewing of their personal information.
                Implement this system here, by ensuring the getters of properties check for this value before returning student information. 
                Student ID and Name are exempt from needing to be checked.
             */
            var startDateString = student.StartDate == null ? Student.AccessError : student.StartDate.ToString();
            var gradDateString = student.StartDate == null ? Student.AccessError : student.StartDate.ToString();
            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Major: {student.Major}");
            Console.WriteLine($"Start Date: {startDateString}");
            Console.WriteLine($"Anticipated Graduation Date: {gradDateString}");
            Console.WriteLine($"Mailing Address: {student.MailingAddress}");
            Console.WriteLine($"State/Province: {student.StateProvince}");
            Console.WriteLine($"Country: {student.Country}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine($"Phone: {student.Phone}");
        }
    }
}
