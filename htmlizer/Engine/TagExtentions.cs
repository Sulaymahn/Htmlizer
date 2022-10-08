using htmlizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Engine
{
    public static class TagExtentions
    {
        public static string Print(this IHtmlTag tag)
        {
            var sb = new StringBuilder();
            switch (tag.TagType)
            {
                case Constants.Tagtype.Container:
                    sb.Append($"<{tag.Name}");
                    foreach(var attribute in tag.Attributes)
                    {
                        sb.Append($" {attribute.Name}=\"{attribute.Value}\"");
                    }
                    sb.Append('>');
                    if (!string.IsNullOrEmpty(tag.Text)){
                        sb.Append(tag.Text);
                    }
                    foreach (var innertag in tag.Children)
                    {
                        innertag.Print();
                    }
                    sb.Append($"</{tag.Name}>");
                    return sb.ToString();
                case Constants.Tagtype.NonContainer:
                    sb.Append($"<{tag.Name}");
                    foreach (var attribute in tag.Attributes)
                    {
                        sb.Append($" {attribute.Name}=\"{attribute.Value}\"");
                    }
                    sb.Append("/>");
                    return sb.ToString();
                default:
                    throw new ArgumentException("Cannot deduce tag type");
            }
        }
    }
}
