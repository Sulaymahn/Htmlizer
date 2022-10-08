using Htmlizer.Constants;
using Htmlizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Bases
{
    public abstract class TextTag : TagBase
    {
        public override Tagtype TagType => Tagtype.Text;
        public override string Text { get; set; } = string.Empty;
    }
}
