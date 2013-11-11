using NUnit.Framework;

namespace TeaParty
{
    [TestFixture]
    public sealed class GuestGreeterTests
    {
        [TestCase("Austen")]
        [TestCase("Jones")]
        public void AWomanIsGreetedAsMs(string surname)
        {
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet(surname, false, false);
            Assert.That(greeting, Is.EqualTo("Hello Ms. " + surname));
        }

        [TestCase("Orwell")]
        [TestCase("Jones")]
        public void AManIsGreetedAsMr(string surname)
        {
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet(surname, true, false);
            Assert.That(greeting, Is.EqualTo("Hello Mr. " + surname));
        }

        [Test]
        public void ASirIsGreetedAsSir()
        {
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet("Newton", true, true);
            Assert.That(greeting, Is.EqualTo("Hello Sir. Newton"));
        }
    }
}
