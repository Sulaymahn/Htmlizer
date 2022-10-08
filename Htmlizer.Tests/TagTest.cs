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
            var tag = "Hello".ToHeading(1);
            Assert.That($"{tag}", Is.EqualTo("<h1>Hello</h1>"));
        }
        [Test]
        public void NestedTagPararaphTest()
        {
            var paragraph = "hey".ToParagraph(); 
            paragraph.Add("Hello".ToItalic());
            Assert.That($"{paragraph}", Is.EqualTo("<p>hey<i>Hello</i></p>"));
        }

        [Test]
        public void HtmlFileTest()
        {
            var html = new Html();
            html.Head.Add("Htmlizer".ToTitle());
            html.Body.Add("Hello world!".ToParagraph());
            Assert.That($"{html}", Is.EqualTo("<!DOCTYPE html><html><head><title>Htmlizer</title></head><body><p>Hello world!</p></body></html>"));
        }
    }
}