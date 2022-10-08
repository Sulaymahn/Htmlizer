using Htmlizer.Engine;
using Htmlizer.Tags;


var html = new Html();
html.Head.Add("Htmlizer".ToTitle());
html.Body.Add("Hello world!".ToHeading(1));
html.Compile(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "index");