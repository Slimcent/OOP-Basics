using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOP
{
     public static class Validation
    {

        public static Gender GenderSelection(string gender)
        {

            switch (gender)
            {
                case "1":
                    return Gender.Male;
                case "2":
                    return Gender.Female;
                case "3":
                    return Gender.PreferNotToSay;
                default:
                    return Gender.SelectGender;
            }
        }
        public static void InvalidError(string field )
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Selection");
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            }
            catch
            {
                return false;
            }
        }

        public static void EmptyPrompt(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot be empty, Re-enter your {field}");
        }

        public static void LessThanThreePrompt(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot be less than 3 characters, Re-enter your {field}");
        }

        public static void GreaterThanTen(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot be greater than 10 characters, Re-enter your {field}");
        }

        public static void ContainsNumber(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot contain nmbers, Re-enter your {field}");
        }

        public static void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void MatchPassword(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Passwords do not match, Re-enter your Confirm Password");
        }

        public static void DateError(string birthday)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Birhday not valid, Re_enter a valid Birthday");
            Console.ResetColor();
        }

        public static void EmailPrompt(string email)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a valid email");
        }
    }
}
