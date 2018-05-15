using System;
using System.Linq;
using Task1.Solution.Interfaces;

namespace Task1.Solution.Implementation
{
    public class Validator2 : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if length more than 10 chars for admins
            if (password.Length >= 15)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            return Tuple.Create(true, "It is valid.");
        }
    }
}