using Htmlizer.Interfaces;
using Htmlizer.Bases;

namespace Htmlizer.Tags
{
    public sealed class Html : ContainerTag
    {
        public override string Name => nameof(Html).ToLower();
    }
}