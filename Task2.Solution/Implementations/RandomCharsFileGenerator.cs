using System;
using System.IO;
using System.Linq;
using Task2.Solution.Abstract;

namespace Task2.Solution.Implementations
{
    public class RandomCharsFileGenerator : RandomFileGenerator<char>
    {
        public RandomCharsFileGenerator()
        {
            WorkingDirectory = "Files with random chars";
            FileExtension = ".txt";
        }

        protected override char[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var chars = generatedString.ToCharArray();

            return chars;
        }

        private string RandomString(int size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }

        protected override void WriteContentToFile(string fileName, char[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllText($"{WorkingDirectory}//{fileName}", new string(content));
        }
    }
}