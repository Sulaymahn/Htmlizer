using Htmlizer.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Htmlizer.Engine
{
    public static class StringExtention
    {
        public static Italic ToItalic(this string value) => new() { Text = value };
        public static Paragraph ToParagraph(this string value) => new() { Text = value };
        public static Heading ToHeading(this string value, int num) => new(num) { Text = value };
    }
}
