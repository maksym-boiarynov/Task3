using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Task3_2nd_term
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            Console.Write("Enter name: ");
            user1.FirstName = NoNumbers();

            Console.Write("Enter surname: ");
            user1.LastName = NoNumbers();

            bool isValidGender = false;
            while (!isValidGender)
            {
                Console.Write("Enter gender (Where 1 for Male, 2 for Female or 3 to not mention your gender): ");
                string genderInput = Console.ReadLine();

                if (Enum.TryParse(genderInput, out GenderType gender))
                {
                    if (Enum.IsDefined(typeof(GenderType), gender))
                    {
                        user1.Gender = gender;
                        isValidGender = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect format of data. Use 1 for Male, 2 for Female or 3 for no gender");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect format of data.");
                }
            }
            if (user1.Age <= 10)
            {
                Console.WriteLine($"Hi, my name is: {user1.FirstName} and last name {user1.LastName}. I am a baby. I am {user1.Gender}.");
            }
            else 
            {
                Console.WriteLine($"Hi, my name is: {user1.FirstName} and last name {user1.LastName}. I am {user1.Age} years old. I am {user1.Gender}.");
            }
        }
        static string NoNumbers()
        {
            string user_input;
            do
            {
                user_input = Console.ReadLine();
                if (!Validator(user_input))
                {
                    Console.WriteLine("Error.Name and surname should not contain numbers. Please enter again:");
                }
            } while (!Validator(user_input));

            return user_input;
        }

        static bool Validator(string user_input)
        {
            return !Regex.IsMatch(user_input, @"\d");
        }
    }
}