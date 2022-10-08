using Htmlizer.Interfaces;
using Htmlizer.Engine;
using Htmlizer.Tags;
using NUnit.Framework;

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
            string result = tag.ToHtml();
            Assert.That(result, Is.EqualTo("<h1>Hello</h1>"));
        }
        [Test]
        public void NestedTagPararaphTest()
        {
            var paragraph = new Paragraph() { Text= "hey"};
            paragraph.AddChild(new Italic { Text = "Hello" });
            string result = paragraph.ToHtml();
            Assert.That(result, Is.EqualTo("<p>hey<i>Hello</i></p>"));
        }
    }
}