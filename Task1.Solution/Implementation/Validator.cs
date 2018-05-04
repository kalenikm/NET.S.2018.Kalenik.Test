﻿using System;
using System.Linq;
using Task1.Solution.Interfaces;

namespace Task1.Solution.Implementation
{
    public class Validator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == string.Empty)
            {
                return Tuple.Create(false, $"{password} is empty");
            }

            // check if length more than 7 chars 
            if (password.Length <= 7)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
            {
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            }

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
            {
                return Tuple.Create(false, $"{password} hasn't digits");
            }

            return Tuple.Create(true, "It is valid.");
        }
    }
}