using Htmlizer.Interfaces;
using Htmlizer.Engine;
using Htmlizer.Tags;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace Htmlizer.Tests
{
    public class TagTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleTagH1Test()
        {
            var tag = new Heading(1)
            {
                Text = "Hello"
            };
            Assert.That(tag.ToHtml(), Is.EqualTo("<h1>Hello</h1>"));
        }
        [Test]
        public void NestedTagPararaphTest()
        {
            var paragraph = new Paragraph() { Text = "hey" };
            paragraph.AddChild(new Italic { Text = "Hello" });
            Assert.That(paragraph.ToHtml(), Is.EqualTo("<p>hey<i>Hello</i></p>"));
        }

        [Test]
        public void HtmlFileTest()
        {
            var html = new Html();
            html.Body.AddChild(new Paragraph() { Text = "Hello world!" });

            Assert.That(html.ToHtml(), Is.EqualTo("<html><head></head><body><p>Hello world!</p></body></html>"));
        }
    }
}