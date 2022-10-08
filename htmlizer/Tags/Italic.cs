using Htmlizer.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Tags
{
    public class Italic : TextTag
    {
        public override string Name => "i";
        public override string Text { get; set; } = string.Empty;
    }
}
