using Htmlizer.Engine;
using Htmlizer.Tags;
using NUnit.Framework;
using System.Security.Cryptography;

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
            var tag = new H1
            {
                Text = "Hello"
            };
            string result = tag.Print();
            Assert.That(result, Is.EqualTo("<h1>Hello</h1>"));
        }
    }
}