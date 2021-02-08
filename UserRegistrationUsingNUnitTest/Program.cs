﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingNUnitTest
{
    public class UserRegex
    {
        Regex firstNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
        Regex lastNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
        Regex emailregex = new Regex("^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}(.[][a-zA-Z]{2})*$");
        Regex mobileNumberregex = new Regex(@"^[0-9]{2,}\s[0-9]{10,}$");
        Regex passwordRule1regex = new Regex(@"^.{8,}$");
        Regex passwordRule2regex = new Regex(@"^(?=.*[A-Z]).{8,}$");
        public bool FirstNameRegex(string firstname)
        {
            return (firstNameregex.IsMatch(firstname)); 
        }

        public bool LastNameRegex(string lastName)
        {
            return (lastNameregex.IsMatch(lastName));
        }
        public bool EmailRegex(string email)
        {
            return (emailregex.IsMatch(email));
        }
        public bool MobileNumberRegex(string mobileNumber)
        {
            return (mobileNumberregex.IsMatch(mobileNumber));
        }
        public bool PasswordRule1Regex(string passwordRule1)
        {
            return (passwordRule1regex.IsMatch(passwordRule1));
        }
        public bool PasswordRule2Regex(string passwordRule2)
        {
            return (passwordRule2regex.IsMatch(passwordRule2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration NUnit testing");
        }
    }
}
