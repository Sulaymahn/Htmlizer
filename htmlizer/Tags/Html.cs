using htmlizer.Interfaces;
using Htmlizer.Bases;

namespace Htmlizer.Tags
{
    public sealed class Html : ContainerTag
    {
        public override string Name => nameof(Html).ToLower();
        public override string Text { get; set; } = String.Empty;
    }
}