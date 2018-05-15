using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            IRepository repository = new SqlRepository();
            PasswordService service = new PasswordService(repository);
            
            var validators = new List<IValidator>() { new Validator1(), new Validator2(), new Validator3(), new Validator4()};

            var result = service.AddPassword("111", validators);
            System.Console.WriteLine(result.Item1);
            foreach (var item in result.Item2)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();

            result = service.AddPassword("fn939jf32f-02f", validators);
            System.Console.WriteLine(result.Item1);
            foreach (var item in result.Item2)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
