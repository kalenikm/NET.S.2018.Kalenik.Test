using System;
using System.Collections.Generic;
using System.Text;
using Task5.Solution.Converters;
using Task5.Solution.Interfaces;

namespace Task5.Solution
{
    public class Document
    {
        public List<DocumentPart> DocumentParts { get; set; }

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (ReferenceEquals(null, parts))
            {
                throw new ArgumentNullException($"{nameof(parts)} is null.");
            }

            DocumentParts = new List<DocumentPart>(parts);
        }

        public string Print(IConverter converter = null)
        {
            if (ReferenceEquals(null, converter))
            {
                converter = new PlainConverter();
            }

            StringBuilder output = new StringBuilder();

            foreach (var part in DocumentParts)
            {
                output.Append(converter.Convert(part) + "\n");
            }

            return output.ToString();
        }
    }
}