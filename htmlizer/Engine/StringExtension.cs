using Htmlizer.Tags;

namespace Htmlizer.Engine
{
    public static class StringExtension
    {
        public static Italic ToItalic(this string value) => new() { Text = value };
        public static Paragraph ToParagraph(this string value) => new() { Text = value };
        public static Title ToTitle(this string value) => new() { Text = value };
        public static Heading ToHeading(this string value, int num) => new(num) { Text = value };
    }
}
