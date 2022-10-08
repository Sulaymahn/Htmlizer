﻿using Htmlizer.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlizer.Interfaces
{
    public interface IHtmlTag
    {
        string Name { get; }
        string Text { get; set; }
        Tagtype TagType { get; }
        IEnumerable<IHtmlTag> Children { get; }
        IEnumerable<IHtmlAttribute> Attributes { get; }
        IEnumerable<IHtmlAttribute> SupportdAttributes { get; }
        IEnumerable<IHtmlAttribute> RequiredAttributes { get; }
        void AddAttribute(IHtmlAttribute attribute);
    }
}
