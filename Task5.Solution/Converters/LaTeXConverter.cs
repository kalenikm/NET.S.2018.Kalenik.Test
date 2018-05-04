using Task5.Solution.DocumentParts;
using Task5.Solution.Interfaces;

namespace Task5.Solution.Converters
{
    public class LaTeXConverter : IConverter
    {
        public string Convert(DocumentPart part)
        {
            return ToLaTeX((dynamic)part);
        }

        private string ToLaTeX(PlainText text)
        {
            return text.Text;
        }

        private string ToLaTeX(BoldText text)
        {
            return "\\textbf{" + text.Text + "}";
        }

        private string ToLaTeX(HyperLink text)
        {
            return "\\href{" + text.Url + "}{" + text.Text + "}";
        }
    }
}