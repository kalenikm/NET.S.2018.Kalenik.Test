using System;
using System.Linq;
using Task1.Solution.Interfaces;

namespace Task1.Solution.Implementation
{
    public class Validator3 : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
            {
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            }

            return Tuple.Create(true, "It is valid.");
        }
    }
}