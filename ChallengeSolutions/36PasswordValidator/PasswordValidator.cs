using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36PasswordValidator
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (password.Length < 6) return false;
            if (password.Length > 13) return false;
            if (Contains(password, 'T')) return false;
            if (Contains(password,'&')) return false;
            if(!HasNumbers(password)) return false;
            if(!HasUpperCase(password)) return false;
            if(!HasLowerCase(password)) return false;

            return true;
        }

        private bool Contains(string password, char letter)
        {
            foreach (char character in password)
            {
                if (character == letter)
                {
                    return true;
                }    
            }
            return false;
        }
        private bool HasLowerCase(string password)
        {
            foreach (char letter in password)
            {
                if (char.IsLower(letter))
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasUpperCase(string password)
        {
            foreach (char letter in password)
            {
                if (char.IsUpper(letter))
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasNumbers(string password)
        {
            foreach(char letter in password)
            {
                if (char.IsNumber(letter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
