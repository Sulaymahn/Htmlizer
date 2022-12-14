using Htmlizer.Interfaces;
using Htmlizer.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Bases
{
    public abstract class ContainerTag : TagBase
    {
        public override string Text { get; set; } = string.Empty;
        public override Tagtype TagType => Tagtype.Container;
    }
}
