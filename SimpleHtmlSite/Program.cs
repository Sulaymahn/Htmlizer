using Htmlizer.Engine;
using Htmlizer.Tags;

var paragraph = new Paragraph()
{ 
    Text = $" I am so {new Italic() { Text = "Angry"}.ToHtml()}"
};

Console.WriteLine(paragraph.ToHtml());