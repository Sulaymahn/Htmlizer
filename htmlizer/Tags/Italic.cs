using Htmlizer.Bases;

namespace Htmlizer.Tags
{
    public class Italic : TextTag
    {
        public override string Name => "i";
        public override string Text { get; set; } = string.Empty;
    }
}
