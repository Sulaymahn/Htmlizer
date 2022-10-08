using Htmlizer.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Tags
{
    public class Div : ContainerTag
    {
        public override string Name => "div";
        public override string Text { get; set; } = string.Empty;
    }
}
