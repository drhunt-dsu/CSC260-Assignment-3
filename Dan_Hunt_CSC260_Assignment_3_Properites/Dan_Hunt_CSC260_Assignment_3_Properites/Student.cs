//Dan Hunt
//daniel.hunt@trojans.dsu.edu
//CSC260 Assignment 3

using System;
using System.Collections.Generic;
using System.Text;

namespace Dan_Hunt_CSC260_Assignment_3_Properites
{
    class Student
    {
        //Properties
        private readonly int _id;

        //Fields
        //Required fields:
        //Name, Major, StartDate, Anticipated Graduation Date, State/Province/Territory, Country, Email, Phone #, Mailing Address.
        //StudentID is read only and should be passed in via constructor.

        private int Id => _id; //same as {get {return _id;}}. Suggested by my best friend Resharper

        //default constructor here


        //parameterized constructor here



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
