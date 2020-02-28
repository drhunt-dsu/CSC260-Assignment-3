using System;
using System.ComponentModel.DataAnnotations;

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
            OutputAllStudentInfo(korben, true);
            Console.WriteLine("*** Output Student info without permission");
            OutputAllStudentInfo(korben, false);
        }

        private static Student CreateExampleStudent()
        {
            var student = new Student(1997);
            student.Name = "Korben Dallas";
            student.Major = "English and Bad English";
            student.MailingAddress = "5000 block Apt 281-53, New York";
            student.StateProvince = "NY";
            student.Country = "USA";
            student.Email = "kdallas@ZorgIndustries.com";
            student.Phone = "555-867-5309";


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
            validationStudent.Phone = "This is not a phone number";

            return validationStudent;
        }

        /// <summary>
        /// Outputs all student info
        /// </summary>
        /// <param name="student"></param>
        private static void OutputAllStudentInfo(Student student, bool hasAccess)
        {
            //Bool hasAccess is for this condition of the assignment:
            /*
             * Historically, systems like WebAdvisor and Banner have allowed students to restrict the viewing of their personal information.
                Implement this system here, by ensuring the getters of properties check for this value before returning student information. 
                Student ID and Name are exempt from needing to be checked.
             */
            

        }
    }
}
