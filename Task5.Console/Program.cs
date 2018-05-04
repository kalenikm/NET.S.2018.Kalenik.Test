using Task5.Solution.Converters;
using Task5.Solution.DocumentParts;

namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5.Solution;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new HyperLink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);

            Console.WriteLine(document.Print(new HtmlConverter()));

            Console.WriteLine(document.Print(new PlainConverter()));

            Console.WriteLine(document.Print(new LaTeXConverter()));
        }
    }
}
