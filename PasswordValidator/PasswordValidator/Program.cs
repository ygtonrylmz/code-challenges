using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PasswordValidator
{
    class Program
    {
        public static bool IsValid(string password)
        {
            // Solution 1
            //return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            // Solution 2
            if (password.Length < 8 && password.Length > 15) return false;

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsNumber))
                return false;

            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] _specialCh = specialCh.ToCharArray();
            foreach (char ch in _specialCh)
            {
                if (password.Contains(ch))
                    return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            // The conditions are 
            // string must be between 8 and 15 characters long. 
            // string must contain at least one number. 
            // string must contain at least one uppercase letter. 
            // string must contain at least one lowercase letter.
            // string must contain at least one special letter.
            string password = "change";
            Console.WriteLine(IsValid(password));
        }
    }
}
