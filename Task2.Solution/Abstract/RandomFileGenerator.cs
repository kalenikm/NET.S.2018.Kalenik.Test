using System;

namespace Task2.Solution.Abstract
{
    public abstract class RandomFileGenerator<T>
    {
        public string WorkingDirectory { get; protected set; }
        public string FileExtension { get; protected set; }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteContentToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract T[] GenerateFileContent(int contentLength);
        protected abstract void WriteContentToFile(string fileName, T[] content);
    }
}