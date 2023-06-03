using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace OOP
{
    public static class Application
    {
        public static void Run()
        {
            var menu = new StringBuilder();
            menu.Append("Hello, welcome to my App:\n");
            menu.AppendLine("Enter your FirstName");
            Console.WriteLine(menu.ToString());
            var firstName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    Validation.EmptyPrompt("firstName");
                }
                else if (firstName.Length < 3)
                {
                    Validation.LessThanThreePrompt("firstname");
                }
                else if (firstName.Length > 10)
                {
                    Validation.GreaterThanTen("firstname");
                }
                else if (firstName.Any(c => char.IsDigit(c)))
                {
                    Validation.ContainsNumber("firstname");
                }
                else break;
                Console.ResetColor();
                firstName = Console.ReadLine();
            }
            Validation.DisplayInfo();
            Console.WriteLine($"Your First Name is {firstName}");
            Console.ResetColor();


            Console.WriteLine("Enter Lastname");
            var lastName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    Validation.EmptyPrompt("lastname");
                }
                else if (lastName.Length < 3)
                {
                    Validation.LessThanThreePrompt("lastname");
                }
                else if (lastName.Length > 10)
                {
                    Validation.GreaterThanTen("lastname");
                }
                else if (lastName.Any(c => char.IsDigit(c)))
                {
                    Validation.ContainsNumber("lastname");
                }
                else break;
                Console.ResetColor();
                lastName = Console.ReadLine();

            }
            Validation.DisplayInfo();
            Console.WriteLine($"Your Last Name is {lastName}");
            Console.ResetColor();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(email))
                {
                    Validation.EmptyPrompt("email");
                }
                else if (!Validation.IsValidEmail(email))
                {
                    Validation.EmailPrompt("email");
                }
                else break;
                Console.ResetColor();
                email = Console.ReadLine();
            }
            Validation.DisplayInfo();
            Console.WriteLine($"Your Email is {email}");
            Console.ResetColor();

            Console.WriteLine("Enter birthday in the format dd/mm/yyyy");
            var birthday = Console.ReadLine();
            DateTime result;
            while (!DateTime.TryParse(birthday, out result))
            {
                Validation.DateError("birthday");
                birthday = Console.ReadLine();
            }
            Validation.DisplayInfo();
            Console.WriteLine($"Your Birthday is {birthday}");
            Console.ResetColor();

            Console.WriteLine("Select your Gender: \n 1. male \n 2. Female \n 3. Prefer not to say");
            var gender = Console.ReadLine();
            while (gender != "1" && gender != "2" && gender != "3")
            {
                Validation.InvalidError("gender");
                Console.ResetColor();
                gender = Console.ReadLine();
            }
            var selectedGender = Validation.GenderSelection(gender);
            Validation.DisplayInfo();
            Console.WriteLine($"Your Gender is " + selectedGender);
            Console.ResetColor();

            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(password))
                {
                    Validation.EmptyPrompt("password");
                }
                else if (password.Length > 10)
                {
                    Validation.GreaterThanTen("password");
                }
                else if (password.Length < 3)
                {
                    Validation.LessThanThreePrompt("password");
                }
                else break;
                Console.ResetColor();
                password = Console.ReadLine();
            }
            Validation.DisplayInfo();
            Console.WriteLine($"Your Password is {firstName}");
            Console.ResetColor();


            Console.WriteLine("Confirm Password");
            var confirmPassword = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(confirmPassword))
                {
                    Validation.EmptyPrompt("confirmPassword");
                }
                else if (confirmPassword != password)
                {
                    Validation.MatchPassword("confirmPassword");
                }
                else break;
                Console.ResetColor();
                confirmPassword = Console.ReadLine();
            }

            var formData = new Register { 
                FirstName = firstName, 
                LastName = lastName,
                Email = email,
                Birthday = DateTime.Parse(birthday),
                Password = password,
                ConfirmPassword = confirmPassword,
                Gender = selectedGender };

            AccountService.Register(formData);
        }
    }
}
