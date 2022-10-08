using Htmlizer.Constants;
using Htmlizer.Engine;
using Htmlizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Bases
{
    public abstract class TagBase : IHtmlTag
    {
        public abstract string Name { get; }
        public abstract string Text { get; set; }
        public abstract Tagtype TagType { get; }
        public IEnumerable<IHtmlTag> Children { get; protected set; } = new List<IHtmlTag>();
        public IEnumerable<IHtmlAttribute> Attributes { get; protected set;} = new List<IHtmlAttribute>();
        public IEnumerable<IHtmlAttribute> AllowedAttributes { get; protected set; } = new List<IHtmlAttribute>();
        public IEnumerable<IHtmlAttribute> RequiredAttributes { get; protected set; } = new List<IHtmlAttribute>();
        public virtual void AddAttribute(IHtmlAttribute attribute) => Attributes = Attributes.Append(attribute);
        public virtual void AddChild(IHtmlTag tag) => Children = Children.Append(tag);
        public override string ToString() => this.ToHtml();
    }
}
