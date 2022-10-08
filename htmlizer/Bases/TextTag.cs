using Htmlizer.Constants;
using htmlizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Bases
{
    public abstract class TextTag : IHtmlTag
    {
        public abstract string Name { get; }
        public abstract string Text { get; set; }
        public Tagtype TagType => Tagtype.Text;
        public IEnumerable<IHtmlAttribute> Attributes { get; } = new List<IHtmlAttribute>();
        public IEnumerable<IHtmlTag> Children { get; set; } = new List<IHtmlTag>();
        public IEnumerable<IHtmlAttribute> SupportdAttributes { get; } = new List<IHtmlAttribute>();
        public IEnumerable<IHtmlAttribute> RequiredAttributes { get; } = new List<IHtmlAttribute>();
        public void AddAttribute(IHtmlAttribute attribute)
        {
            Attributes.Append(attribute);
        }
    }
}
