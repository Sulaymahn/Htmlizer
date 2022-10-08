using Htmlizer.Engine;
using Htmlizer.Tags;


var paragraph = new Paragraph()
{ 
    Text = $" I am so {new Italic() { Text = "Angry"}.ToHtml()}"
};
var div = new Div();
div.Add(paragraph);

Console.WriteLine(paragraph.ToHtml());