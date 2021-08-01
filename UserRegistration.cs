using System;
using System.Text.RegularExpressions;

namespace DAY20
{
    public class UserRegistration
    {

        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static string Regex_email = "^[A-Za-z]{1,}([.!#$%&+-_][A-Za-z0-9]{1,})*[@][A-Za-z0-9]{1,}[.][A-Za-z]{2,}([.][A-Za-z]{2,})*$";
        public static string Regex_PhoneNumber = "^([9][1])[ ][6-9][0-9]{9}$";
        public static string Regex_Password = "^((?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*-_.])[A-Za-z0-9!@#$%^&*-_.]{8,})$";

        public static bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }


        public static void checkFirstName(string FirstName)
        {
            try
            {

                if (FirstName == String.Empty || FirstName == " ")
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Field is empty ");
                }

                else if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Enter valid First Name");
                }
               
                else
                {
                    Console.WriteLine("It is Valid!");

                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public static bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }

        public static void checkLastName(string LastName)
        {
            try
            {
                if (LastName == String.Empty || LastName == " ")
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Field is empty ");
                }

                else if (Regex.IsMatch(LastName, Regex_LastName) == false)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Enter valid First Name");
                }
                else
                {
                    Console.WriteLine("It is Valid!");

                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool Validateemail(string email)
        {
            return Regex.IsMatch(email, Regex_email);
        }

        public static void checkemail(string email)
        {
            try
            {
                if (email == String.Empty || email == " ")
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Field is empty ");
                }

                else if (Regex.IsMatch(email, Regex_email) == false)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Enter valid First Name");
                }
                else
                {
                    Console.WriteLine("It is Valid!");

                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static bool ValidatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }

        public static void checkPhoneNumber(string PhoneNumber)
        {

            try
            {
                if (PhoneNumber == String.Empty || PhoneNumber == " ")
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Field is empty ");
                }

                else if (Regex.IsMatch(PhoneNumber, Regex_PhoneNumber) == false)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Enter valid First Name");
                }
                else
                {
                    Console.WriteLine("It is Valid!");

                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }

        public static void checkPassword(string Password)
        {

            try
            {
                if (Password == String.Empty || Password == " ")
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "Field is empty ");
                }

                else if (Regex.IsMatch(Password, Regex_Password) == false)
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT, "Enter valid First Name");
                }
                else
                {
                    Console.WriteLine("It is Valid!");

                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
