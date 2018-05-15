using System;
using System.Linq;
using Task1.Solution.Interfaces;

namespace Task1.Solution.Implementation
{
    public class Validator4 : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
            {
                return Tuple.Create(false, $"{password} hasn't digits");
            }

            return Tuple.Create(true, "It is valid.");
        }
    }
}