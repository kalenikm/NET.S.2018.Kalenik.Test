using System;
using System.IO;
using Task2.Solution.Abstract;

namespace Task2.Solution.Implementations
{
    public class RandomBytesFileGenerator : RandomFileGenerator<byte>
    {

        public RandomBytesFileGenerator()
        {
            WorkingDirectory = "Files with random bytes";
            FileExtension = ".bytes";
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        protected override void WriteContentToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}