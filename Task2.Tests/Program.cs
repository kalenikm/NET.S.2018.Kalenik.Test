using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution.Abstract;
using Task2.Solution.Implementations;

namespace Task2.Tests
{
    public static class Program
    {
        public static void Main()
        {
            RandomFileGenerator<char> generator1 = new RandomCharsFileGenerator();
            RandomFileGenerator<byte> generator2 = new RandomBytesFileGenerator();

            generator1.GenerateFiles(2, 5);
            generator2.GenerateFiles(1, 9);
        }
    }
}
