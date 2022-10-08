using htmlizer.Interfaces;
using Htmlizer.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Tags
{
    public sealed class H1 : ContainerTag
    {
        public override string Name { get => nameof(H1).ToLower(); }
        public override string Text { get; set; } = string.Empty;
    }
}
