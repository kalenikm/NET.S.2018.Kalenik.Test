using System;
using System.Linq;
using Task1.Solution.Interfaces;

namespace Task1.Solution.Implementation
{
    public class Validator1 : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= 7)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            return Tuple.Create(true, "It is valid.");
        }
    }
}