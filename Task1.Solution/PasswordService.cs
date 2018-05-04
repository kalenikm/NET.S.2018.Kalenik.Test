using System;
using Task1.Solution.Interfaces;

namespace Task1.Solution
{
    public class PasswordService
    {
        public Tuple<bool, string> AddPassword(string password, IValidator validator, IRepository repository)
        {
            if (ReferenceEquals(null, password))
            {
                throw new ArgumentNullException($"{nameof(password)} is null.");
            }

            if (ReferenceEquals(null, validator))
            {
                throw new ArgumentNullException($"{nameof(validator)} is null.");
            }

            if (ReferenceEquals(null, repository))
            {
                throw new ArgumentNullException($"{nameof(password)} is null.");
            }

            var result = validator.IsValid(password);

            if (result.Item1)
            {
                repository.Save(password);
                return Tuple.Create(true, "Password is Ok. User was created");
            }

            return result;
        }
    }
}