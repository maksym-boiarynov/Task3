using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3_2nd_term
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }
        public GenderType Gender { get; set; }

        public User()
        {
            Age = 21;
        }

        public User(int age)
        {
            Age = age;
        }
    }
    enum GenderType
    {
        Male,male = 1,
        Female,female = 2,
        Not_mentioned = 3,
    }
}