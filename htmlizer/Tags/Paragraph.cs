using Htmlizer.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Tags
{
    public class Paragraph : TextTag
    {
        public override string Name => "p";
        public override string Text { get; set; } = string.Empty;
    }
}
