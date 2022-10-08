using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlizer.Interfaces
{
    public interface IHtmlTag
    {
        string Name { get; set; }
        string Content { get; set; }
        bool HasEndTag { get; set; }
        bool CanHaveMultipleChildren { get; set; }
        List<IHtmlTag> Children { get; set; }
        List<IHtmlAttribute> SupportdAttributes { get; set; }
        List<IHtmlAttribute> RequiredAttributes { get; set; }
    }
}
