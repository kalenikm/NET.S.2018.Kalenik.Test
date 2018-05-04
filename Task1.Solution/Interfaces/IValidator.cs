using System;

namespace Task1.Solution.Interfaces
{
    public interface IValidator
    {
        Tuple<bool, string> IsValid(string password);
    }
}