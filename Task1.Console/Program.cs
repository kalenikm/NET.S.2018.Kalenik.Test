using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1.Solution;
using Task1.Solution.Implementation;
using Task1.Solution.Interfaces;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordService service = new PasswordService();
            IValidator validator = new Validator();
            IRepository repository = new SqlRepository();
            var result = service.AddPassword("111", validator, repository);
            System.Console.WriteLine(result);
            result = service.AddPassword("fn939jf32f-02f", validator, repository);
            System.Console.WriteLine(result);
        }
    }
}
