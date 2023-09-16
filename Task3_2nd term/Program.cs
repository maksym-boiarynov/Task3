using System;
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
            Console.WriteLine("Info about person:");
            Console.WriteLine($"Name: {user1.FirstName}, Surname: {user1.LastName}, Age: {user1.Age}, Gender: {user1.Gender}");
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