using htmlizer.Interfaces;
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
            string result = tag.Print();
            Assert.That(result, Is.EqualTo("<h1>Hello</h1>"));
        }
        [Test]
        public void NestedTagPararaphTest()
        {

            var paragraph = new Paragraph()
            {
                Children = new List<IHtmlTag>
                {
                    new Italic { Text = "Hello" }
                }
            };
            string result = paragraph.Print();
            Assert.That(result, Is.EqualTo("<p><i>Hello</i></p>"));
        }
    }
}