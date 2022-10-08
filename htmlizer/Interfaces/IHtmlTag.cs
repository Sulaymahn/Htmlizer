using Htmlizer.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Interfaces
{
    public interface IHtmlTag
    {
        string Name { get; }
        string Text { get; }
        Tagtype TagType { get; }
        IEnumerable<IHtmlTag> Children { get; }
        IEnumerable<IHtmlAttribute> Attributes { get; }
        IEnumerable<IHtmlAttribute> AllowedAttributes { get; }
        IEnumerable<IHtmlAttribute> RequiredAttributes { get; }
        void AddAttribute(IHtmlAttribute attribute);
        void AddChild(IHtmlTag tag);
    }
}
