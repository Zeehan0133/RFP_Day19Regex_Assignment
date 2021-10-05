using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_Ass
{
    class Method
    {
        string Regex_FirstName = "^[A-Z][a-z]{2,}$";

        public bool validFirstName(string FirstName)
        {

            return Regex.IsMatch(FirstName, Regex_FirstName);
        }

        string Regex_LastName = "^([A-Z]?[a-z]*){3,}$";

        public bool validLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }

        string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool validEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }


        string Regex_MobileNum = "^([0-9]{2}[ ])?[0-9]{10}$";

        public bool validMobileNum(string MobileNum)
        {

            return Regex.IsMatch(MobileNum, Regex_MobileNum);



        }

        string Regex_Password = "((?=.[0-9])(?=.[a-z])(?=.[A-Z])(?=.[@#$%]).{8,})";

        public bool validPassword(string Password)
        {

            return Regex.IsMatch(Password, Regex_Password);
        }








    }
}
