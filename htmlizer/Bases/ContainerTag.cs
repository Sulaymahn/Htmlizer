using htmlizer.Interfaces;
using Htmlizer.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Bases
{
    public abstract class ContainerTag : IHtmlTag
    {
        public abstract string Name { get; }
        public abstract string Text { get; set; }
        public Tagtype TagType => Tagtype.Container;
        public IEnumerable<IHtmlAttribute> Attributes { get; } = new List<IHtmlAttribute>();
        public IEnumerable<IHtmlTag> Children { get; } = new List<IHtmlTag>();
        public IEnumerable<IHtmlAttribute> SupportdAttributes { get; } = new List<IHtmlAttribute>();
        public IEnumerable<IHtmlAttribute> RequiredAttributes { get; } = new List<IHtmlAttribute>();
        public void AddAttribute(IHtmlAttribute attribute)
        {
            Attributes.Append(attribute);
        }
    }
}
