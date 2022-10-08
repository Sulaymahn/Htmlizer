using Htmlizer.Interfaces;
using Htmlizer.Bases;

namespace Htmlizer.Tags
{
    public sealed class Html : ContainerTag
    {
        public override string Name { get => nameof(Html).ToLower(); }
        public Head Head { get => (Head)Children.First(x => x.GetType() == typeof(Head)); }
        public Body Body { get => (Body)Children.First(x => x.GetType() == typeof(Body)); }
        public Html()
        {
            AddChild(new Head());
            AddChild(new Body());
        }
    }
}