using System;
using Task5.Solution.DocumentParts;
using Task5.Solution.Interfaces;

namespace Task5.Solution.Converters
{
    public class HtmlConverter : IConverter
    {
        public string Convert(DocumentPart part)
        {
            return ToHtml((dynamic)part);
        }

        private string ToHtml(PlainText text)
        {
            return text.Text;
        }

        private string ToHtml(BoldText text)
        {
            return "<b>" + text.Text + "</b>";
        }

        private string ToHtml(HyperLink text)
        {
            return "<a href=\"" + text.Url + "\">" + text.Text + "</a>";
        }
    }
}