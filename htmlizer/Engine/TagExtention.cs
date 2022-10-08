using Htmlizer.Interfaces;
using Htmlizer.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Htmlizer.Tags;

namespace Htmlizer.Engine
{
    public static class TagExtention
    {
        public static string ToHtml(this IHtmlTag tag)
        {
            var sb = new StringBuilder();
            switch (tag.TagType)
            {
                case Tagtype.Container:
                case Tagtype.Text:
                    sb.Append($"<{tag.Name}");
                    foreach (var attribute in tag.Attributes)
                    {
                        sb.Append($" {attribute.Name}=\"{attribute.Value}\"");
                    }
                    sb.Append('>');
                    if (!string.IsNullOrEmpty(tag.Text))
                    {
                        sb.Append(tag.Text);
                    }
                    foreach (var innertag in tag.Children)
                    {
                        sb.Append(innertag.ToHtml());
                    }
                    sb.Append($"</{tag.Name}>");
                    return sb.ToString();
                case Tagtype.NonContainer:
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
        public static void Compile(this Html html, string path, string filename)
        {
            int index = filename.LastIndexOf('.');
            if (index != -1) filename = filename.Remove(index);
            using (var stream = File.CreateText(Path.Combine(path, filename + ".html")))
            {
                stream.Write(html.ToString());
            }
        }
    }
}
