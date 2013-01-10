using CodeDojo.Code.HelloWorld;
using NUnit.Framework;

namespace CodeDojo.UnitTests.HelloWorld
{
    [TestFixture]
    public class HelloWorldMessengerTests
    {
        [Test]
        public void HelloShouldReturnHelloWork()
        {
            var messenger = new HelloWorldMessenger();

            var message = messenger.Hello();

            Assert.That(message, Is.EqualTo("Hello World"));
        }
    }
}