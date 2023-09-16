using System;
using Task3_2nd_term;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();

        Console.Write("Enter name: ");
        user1.FirstName = Console.ReadLine();

        Console.Write("Enter surname: ");
        user1.LastName = Console.ReadLine();

        Console.Write("Enter gender (Where Male is 1 and Female is 2): ");
        string genderInput = Console.ReadLine();
        
        if (Enum.TryParse(genderInput, out GenderType gender))
        {
            user1.Gender = gender;
            Console.WriteLine("Info about person:");
            Console.WriteLine($"Name: {user1.FirstName}, Surname: {user1.LastName}, Age: {user1.Age}, Gender: {user1.Gender}");
        }
        else
        {
            Console.WriteLine("Incorrect format of data. Use 1 for Male or 2 for Female.");
        }
    }
}
