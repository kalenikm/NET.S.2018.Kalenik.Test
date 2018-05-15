using System;
using System.Collections.Generic;
using Task1.Solution.Interfaces;

namespace Task1.Solution
{
    public class PasswordService
    {

        private readonly IRepository _repository;

        public PasswordService(IRepository repository)
        {
            if (ReferenceEquals(null, repository))
            {
                throw new ArgumentNullException($"{nameof(repository)} is null.");
            }

            _repository = repository;
        }

        public Tuple<bool, List<string>> AddPassword(string password, IEnumerable<IValidator> validators)
        {
            if (ReferenceEquals(null, password))
            {
                throw new ArgumentNullException($"{nameof(password)} is null.");
            }

            if (ReferenceEquals(null, validators))
            {
                throw new ArgumentNullException($"{nameof(validators)} is null.");
            }

            var messages = new List<string>();
            bool result = true;

            foreach (var validator in validators)
            {
                if (!ReferenceEquals(null, validator))
                {
                    var res = validator.IsValid(password);
                    if (!res.Item1)
                    {
                        result = false;
                        messages.Add(res.Item2);
                    }
                }
            }

            if (result)
            {
                _repository.Save(password);
                return Tuple.Create(true, new List<string>() {"Password is Ok. User was created"});
            }
            else
            {
                return Tuple.Create(false, messages);
            }

        }
    }
}