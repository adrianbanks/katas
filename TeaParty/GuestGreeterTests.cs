using NUnit.Framework;

namespace TeaParty
{
    [TestFixture]
    public sealed class GuestGreeterTests
    {
        [Test]
        public void AWomanIsGreetedAsMs()
        {
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet("Austen", false);
            Assert.That(greeting, Is.EqualTo("Hello Ms. Austen"));
        }

        [TestCase("Orwell")]
        [TestCase("Jones")]
        public void AManIsGreetedAsMr(string surname)
        {
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet(surname, true);
            Assert.That(greeting, Is.EqualTo("Hello Mr. " + surname));
        }
    }
}
