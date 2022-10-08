using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlizer.Interfaces
{
    public interface IHtmlAttribute
    {
        string Name { get; set; }
        string Value { get; set; }
    }
}
