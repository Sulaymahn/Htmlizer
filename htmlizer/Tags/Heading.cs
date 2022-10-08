using Htmlizer.Interfaces;
using Htmlizer.Bases;
using Htmlizer.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Tags
{
    public sealed class Heading : TextTag
    {
        public override string Name { get => $"h{Number}"; }
        public override string Text { get; set; } = string.Empty;
        public int Number { get; set; }
        public Heading(int num)
        {
            Number = num.WithinInterval(1, 6);
        }
    }
}
