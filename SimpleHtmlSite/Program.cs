using Htmlizer.Interfaces;
using Htmlizer.Engine;
using Htmlizer.Tags;

var paragraph = new Paragraph()
{
    Children = new List<IHtmlTag> { new Italic { Text = "Hello" } }
};

Console.WriteLine(paragraph.Print());



