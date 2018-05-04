using Task5.Solution.DocumentParts;
using Task5.Solution.Interfaces;

namespace Task5.Solution.Converters
{
    public class PlainConverter : IConverter
    {
        public string Convert(DocumentPart part)
        {
            return ToPlain((dynamic)part);
        }

        private string ToPlain(PlainText text)
        {
            return text.Text;
        }

        private string ToPlain(BoldText text)
        {
            return "**" + text.Text + "**";
        }

        private string ToPlain(HyperLink text)
        {
            return text.Text + " [" + text.Url + "]";
        }
    }
}