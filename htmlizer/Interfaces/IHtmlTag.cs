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
        bool HasEndTag { get; set; }
        List<IHtmlAttribute> SupportdAttributes { get; set; }
    }
}
